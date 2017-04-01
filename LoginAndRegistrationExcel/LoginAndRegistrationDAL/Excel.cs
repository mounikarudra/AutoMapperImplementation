using Microsoft.Office.Interop.Excel;
using System;
using System.Configuration;

namespace LoginAndRegistrationDAL
{
    class Excel
    {
        Application _oXL = null;
        _Workbook _oWB;
        _Worksheet _oSheet;
        public bool CreateExcel()
        {
            try
            {
                //Start Excel and get Application object.
                _oXL = new Application();
                _oXL.Visible = true;

                //Get a new workbook.
                _oWB = (_Workbook)(_oXL.Workbooks.Add(""));
                _oSheet = (_Worksheet)_oWB.ActiveSheet;

                //Add table headers going cell by cell.
                _oSheet.Cells[1, 1] = "User Name";
                _oSheet.Cells[1, 2] = "Password";

                _oXL.Visible = false;
                _oXL.UserControl = false;
                _oWB.SaveAs(ConfigurationManager.AppSettings["Path"], Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                    false, false, XlSaveAsAccessMode.xlNoChange,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                _oWB.Close();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool AddDetails(string username, string password)
        {
            _oXL = new Application();
            _oWB = (_oXL.Workbooks.Open(ConfigurationManager.AppSettings["path"]));
            _oSheet = (_Worksheet)_oWB.ActiveSheet;
            int lastRow = _oSheet.UsedRange.Rows.Count;
            _oSheet.Cells[lastRow + 1, 1] = username;
            _oSheet.Cells[lastRow + 1, 2] = password;
            _oWB.Save();
            _oWB.Close();

            return true;

        }
        public bool FetchDetails(string username, string password)
        {
            _oXL = new Application();
            _oWB = (_oXL.Workbooks.Add(ConfigurationManager.AppSettings["path"]));
            _oSheet = (_Worksheet)_oWB.ActiveSheet;
            int totalRows = _oSheet.UsedRange.Rows.Count;
            string usernameCell;
            string passwordCell;
            for (int i = 2; i <= totalRows; i++)
            {
                usernameCell = (string)(_oSheet.Cells[i, 1] as Range).Value;
                passwordCell = (string)(_oSheet.Cells[i, 2] as Range).Value;

                if (username == usernameCell && password == passwordCell)
                {
                    return true;
                }
            }

            return false;
        }
        public bool ChangePassword(string username, string password)
        {
            _oXL = new Application();
            _oWB = (_oXL.Workbooks.Open(ConfigurationManager.AppSettings["path"]));
            _oSheet = (_Worksheet)_oWB.ActiveSheet;
            int totalRows = _oSheet.UsedRange.Rows.Count;
            string usernameCell;
            string passwordCell;
            for (int i = 2; i <= totalRows; i++)
            {
                usernameCell = (string)(_oSheet.Cells[i, 1] as Range).Value;
                passwordCell = (string)(_oSheet.Cells[i, 2] as Range).Value;

                if (username == usernameCell)
                {
                    _oSheet.Cells[i, 2] = password;
                    _oWB.Save();
                    _oWB.Close();

                    return true;
                }
            }

            return false;

        }
    }
}
