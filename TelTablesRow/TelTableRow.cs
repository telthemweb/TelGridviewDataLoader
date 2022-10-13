using System;
using System.Data;
using System.Windows.Forms;

namespace TelTablesRow
{
    public class TelTableRow
    {
        /// <summary>
        /// Fill all data on gridview
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="param"></param>
        /// <param name="sql"></param>
        #region table row
        public void TelLoadDataToDataGriview(DataGridView obj, DataTable dt, int numberrow)
        {
            int i = 0;
            try
            {
                if (numberrow == 1)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0]);
                    }

                }
                else if (numberrow == 2)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1]);
                    }

                }


                else if (numberrow == 3)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2]);
                    }

                }

                else if (numberrow == 4)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3]);
                    }

                }

                else if (numberrow == 5)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4]);
                    }

                }

                else if (numberrow == 6)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5]);
                    }

                }


                else if (numberrow == 7)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
                    }

                }

                else if (numberrow == 8)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
                    }

                }
                else if (numberrow == 9)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
                    }

                }

                else if (numberrow == 10)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9]);
                    }

                }

                else if (numberrow == 11)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10]);
                    }

                }

                else if (numberrow == 12)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11]);
                    }

                }

                else if (numberrow == 13)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12]);
                    }

                }

                else if (numberrow == 14)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13]);
                    }

                }

                else if (numberrow == 15)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14]);
                    }

                }
                else if (numberrow == 16)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15]);
                    }

                }

                else if (numberrow == 17)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16]);
                    }

                }
                else if (numberrow == 18)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17]);
                    }

                }
                else if (numberrow == 19)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18]);
                    }

                }

                else if (numberrow == 20)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19]);
                    }

                }
                else if (numberrow == 21)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19], row[20]);
                    }

                }
                else if (numberrow == 22)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19], row[20], row[21]);
                    }

                }

                else if (numberrow == 23)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19], row[20], row[21], row[22]);
                    }

                }


                else if (numberrow == 24)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19], row[20], row[21], row[22], row[23]);
                    }

                }

                else if (numberrow == 25)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19], row[20], row[21], row[22], row[23], row[24]);
                    }

                }

                else if (numberrow == 26)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19], row[20], row[21], row[22], row[23], row[24], row[25]);
                    }

                }

                else if (numberrow == 27)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19], row[20], row[21], row[22], row[23], row[24], row[25], row[26]);
                    }

                }

                else if (numberrow == 28)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19], row[20], row[21], row[22], row[23], row[24], row[25], row[26], row[27]);
                    }

                }

                else if (numberrow == 29)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19], row[20], row[21], row[22], row[23], row[24], row[25], row[26], row[27], row[28]);
                    }

                }

                else if (numberrow == 30)
                {
                    obj.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        i = i + 1;
                        obj.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19], row[20], row[21], row[22], row[23], row[24], row[25], row[26], row[27], row[28], row[29]);
                    }

                }

                else
                {
                    MessageBox.Show("Number passed is not allowed!!","Telthemweb",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Loaddata on Listview
        public void TelLoadDataListview(ListView obj, DataTable dt, int numberrow)
        {
            int i = 0;
            obj.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                obj.Items.Add(row[0].ToString());

                //obj.Items.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19], row[20], row[21], row[22], row[23], row[24], row[25], row[26], row[27], row[28], row[29]);
            }
        }
        #endregion

    }
}
