using System;
using System.Data.Entity;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
//using System.Collections.Generic;

namespace CHTPZ_TEST_TASK_App.Forms
{
    public partial class frmTaskTest : Form
    {
        public frmTaskTest()
        {
            InitializeComponent();
        }
        public class myRowView
        {
            public int Год { get; set; }
            public double Январь { get; set; }
            public double Февраль { get; set; }
            public double Март { get; set; }
            public double Апрель { get; set; }
            public double Май { get; set; }
            public double Июнь { get; set; }
            public double Июль { get; set; }
            public double Август { get; set; }
            public double Сентябрь { get; set; }
            public double Октябрь { get; set; }
            public double Ноябрь { get; set; }
            public double Декабрь { get; set; }

        }

        private void frmTask1_Load(object sender, EventArgs e)
        {
            using(EF.chtpzDBcontext db = new EF.chtpzDBcontext())
            {
                var query = db.FIRMs.Select(x => new {x.FIRM_ID, x.NAME, JUR_CITY_NAME = x.JUR_CITY.NAME, POST_CITY_NAME = x.POST_CITY.NAME });
                dgvData1.DataSource = query.ToList();
            }

            #region dtvData1 shettings
            dgvData1.Columns["FIRM_ID"].Visible = false;
            dgvData1.Columns["NAME"].HeaderText = "Наименование фирмы";
            dgvData1.Columns["JUR_CITY_NAME"].HeaderText = "Юр. город";
            dgvData1.Columns["POST_CITY_NAME"].HeaderText = "Почтовый город";
            #endregion

            #region Привязки к элементам управления
            txtFirm.DataBindings.Add(new Binding("Enabled", chkFirm, "Checked"));
            txtCity_Post.DataBindings.Add(new Binding("Enabled", chkCity_Post, "Checked"));
            txtCity_Jur.DataBindings.Add(new Binding("Enabled", chkCity_Jur, "Checked"));
            #endregion

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (EF.chtpzDBcontext db = new EF.chtpzDBcontext())
            {
                var query = db.FIRMs.Select(x => new { x.FIRM_ID, x.NAME, JUR_CITY_NAME = x.JUR_CITY.NAME, POST_CITY_NAME = x.POST_CITY.NAME });
                if (chkFirm.Checked) query = query.Where(x => x.NAME.Contains(txtFirm.Text));
                if (chkCity_Jur.Checked) query = query.Where(x => x.JUR_CITY_NAME.Contains(txtCity_Jur.Text));
                if (chkCity_Post.Checked) query = query.Where(x => x.POST_CITY_NAME.Contains(txtCity_Post.Text));
                dgvData1.DataSource = query.ToList();
            }
        }


        private void dgvData1_DataSourceChanged(object sender, EventArgs e)
        {
            lblCount1.Text = dgvData1.Rows.Count.ToString();
        }

        private void btnFilter2_Click(object sender, EventArgs e)
        {
            using (EF.chtpzDBcontext db = new EF.chtpzDBcontext())
            {

                var query = db.DOCUMENTs.Include(x => x.FIRM);
                if (chkNotFirm.Checked)
                {
                    int[] arrFirmId = new int[dgvData1.Rows.Count];
                    for (int i = 0; i < dgvData1.Rows.Count; i++)
                    {
                        arrFirmId[i] = (int)dgvData1.Rows[i].Cells["FIRM_ID"].Value;
                    }
                    query = query.Where(x => !arrFirmId.Contains(x.FIRM_ID));
                }

                var res = from c in query
                          group c by new { c.DOC_DATE.Month,c.DOC_DATE.Year } into g
                          select g;

                //var a = db.DOCUMENTs.Local.GroupBy(x => x.DOC_DATE.ToString("MMMM", new CultureInfo("ru-RU")));
                List<myRowView> lstDataRow = new List<myRowView>();
                foreach (var item in res.OrderBy(x=>x.Key.Year))
                {
                    myRowView curRow = lstDataRow.FirstOrDefault(x => x.Год == item.Key.Year);
                    if (curRow == null)
                    {
                        curRow = new myRowView();
                        lstDataRow.Add(curRow);
                    }

                    curRow.Год = item.Key.Year;
                    switch (item.Key.Month)
                    {
                        case 1:
                            curRow.Январь = item.Sum(x => x.SUM);
                            break;
                        case 2:
                            curRow.Февраль = item.Sum(x => x.SUM);
                            break;
                        case 3:
                            curRow.Март = item.Sum(x => x.SUM);
                            break;
                        case 4:
                            curRow.Апрель = item.Sum(x => x.SUM);
                            break;
                        case 5:
                            curRow.Май = item.Sum(x => x.SUM);
                            break;
                        case 6:
                            curRow.Июнь = item.Sum(x => x.SUM);
                            break;
                        case 7:
                            curRow.Июль = item.Sum(x => x.SUM);
                            break;
                        case 8:
                            curRow.Август = item.Sum(x => x.SUM);
                            break;
                        case 9:
                            curRow.Сентябрь = item.Sum(x => x.SUM);
                            break;
                        case 10:
                            curRow.Октябрь = item.Sum(x => x.SUM);
                            break;
                        case 11:
                            curRow.Ноябрь = item.Sum(x => x.SUM);
                            break;
                        case 12:
                            curRow.Декабрь = item.Sum(x => x.SUM);
                            break;
                    }

                }
                lstDataRow.OrderBy(x => x.Год);
                dgvData2.DataSource = lstDataRow;
            }
        }

        private void dgvData2_DataSourceChanged(object sender, EventArgs e)
        {
            lblCount2.Text = dgvData2.Rows.Count.ToString();
        }
    }
}
