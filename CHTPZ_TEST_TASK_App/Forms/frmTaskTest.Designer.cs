namespace CHTPZ_TEST_TASK_App.Forms
{
    partial class frmTaskTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpData1 = new System.Windows.Forms.GroupBox();
            this.dgvData1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCount1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpFilter1 = new System.Windows.Forms.GroupBox();
            this.chkFirm = new System.Windows.Forms.CheckBox();
            this.chkCity_Post = new System.Windows.Forms.CheckBox();
            this.chkCity_Jur = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtCity_Jur = new System.Windows.Forms.TextBox();
            this.txtCity_Post = new System.Windows.Forms.TextBox();
            this.txtFirm = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvData2 = new System.Windows.Forms.DataGridView();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCount2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkNotFirm = new System.Windows.Forms.CheckBox();
            this.btnFilter2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpData1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.grpFilter1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData2)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpData1);
            this.tabPage1.Controls.Add(this.grpFilter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Этап 2";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpData1
            // 
            this.grpData1.Controls.Add(this.dgvData1);
            this.grpData1.Controls.Add(this.statusStrip1);
            this.grpData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpData1.Location = new System.Drawing.Point(3, 112);
            this.grpData1.Name = "grpData1";
            this.grpData1.Size = new System.Drawing.Size(516, 309);
            this.grpData1.TabIndex = 2;
            this.grpData1.TabStop = false;
            this.grpData1.Text = "Таблица результатов1";
            // 
            // dgvData1
            // 
            this.dgvData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData1.Location = new System.Drawing.Point(3, 16);
            this.dgvData1.Name = "dgvData1";
            this.dgvData1.Size = new System.Drawing.Size(510, 268);
            this.dgvData1.TabIndex = 0;
            this.dgvData1.DataSourceChanged += new System.EventHandler(this.dgvData1_DataSourceChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblCount1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 284);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(510, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "Всего: ";
            // 
            // lblCount1
            // 
            this.lblCount1.Name = "lblCount1";
            this.lblCount1.Size = new System.Drawing.Size(13, 17);
            this.lblCount1.Text = "0";
            // 
            // grpFilter1
            // 
            this.grpFilter1.Controls.Add(this.chkFirm);
            this.grpFilter1.Controls.Add(this.chkCity_Post);
            this.grpFilter1.Controls.Add(this.chkCity_Jur);
            this.grpFilter1.Controls.Add(this.btnOK);
            this.grpFilter1.Controls.Add(this.txtCity_Jur);
            this.grpFilter1.Controls.Add(this.txtCity_Post);
            this.grpFilter1.Controls.Add(this.txtFirm);
            this.grpFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFilter1.Location = new System.Drawing.Point(3, 3);
            this.grpFilter1.Name = "grpFilter1";
            this.grpFilter1.Size = new System.Drawing.Size(516, 109);
            this.grpFilter1.TabIndex = 1;
            this.grpFilter1.TabStop = false;
            this.grpFilter1.Text = "Элементы фильтрации";
            // 
            // chkFirm
            // 
            this.chkFirm.AutoSize = true;
            this.chkFirm.Location = new System.Drawing.Point(6, 19);
            this.chkFirm.Name = "chkFirm";
            this.chkFirm.Size = new System.Drawing.Size(170, 17);
            this.chkFirm.TabIndex = 9;
            this.chkFirm.Text = "Наименование организации";
            this.chkFirm.UseVisualStyleBackColor = true;
            // 
            // chkCity_Post
            // 
            this.chkCity_Post.AutoSize = true;
            this.chkCity_Post.Location = new System.Drawing.Point(6, 45);
            this.chkCity_Post.Name = "chkCity_Post";
            this.chkCity_Post.Size = new System.Drawing.Size(149, 17);
            this.chkCity_Post.TabIndex = 8;
            this.chkCity_Post.Text = "Город почтового адреса";
            this.chkCity_Post.UseVisualStyleBackColor = true;
            // 
            // chkCity_Jur
            // 
            this.chkCity_Jur.AutoSize = true;
            this.chkCity_Jur.Location = new System.Drawing.Point(6, 71);
            this.chkCity_Jur.Name = "chkCity_Jur";
            this.chkCity_Jur.Size = new System.Drawing.Size(170, 17);
            this.chkCity_Jur.TabIndex = 7;
            this.chkCity_Jur.Text = "Город юридического адреса";
            this.chkCity_Jur.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(385, 9);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 91);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Выполнить фильтрацию";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtCity_Jur
            // 
            this.txtCity_Jur.Location = new System.Drawing.Point(191, 69);
            this.txtCity_Jur.Name = "txtCity_Jur";
            this.txtCity_Jur.Size = new System.Drawing.Size(188, 20);
            this.txtCity_Jur.TabIndex = 5;
            // 
            // txtCity_Post
            // 
            this.txtCity_Post.Location = new System.Drawing.Point(191, 43);
            this.txtCity_Post.Name = "txtCity_Post";
            this.txtCity_Post.Size = new System.Drawing.Size(188, 20);
            this.txtCity_Post.TabIndex = 3;
            // 
            // txtFirm
            // 
            this.txtFirm.Location = new System.Drawing.Point(191, 17);
            this.txtFirm.Name = "txtFirm";
            this.txtFirm.Size = new System.Drawing.Size(188, 20);
            this.txtFirm.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(522, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Этап 4";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvData2);
            this.groupBox1.Controls.Add(this.statusStrip2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 309);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблица результатов2";
            // 
            // dgvData2
            // 
            this.dgvData2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData2.Location = new System.Drawing.Point(3, 16);
            this.dgvData2.Name = "dgvData2";
            this.dgvData2.Size = new System.Drawing.Size(510, 268);
            this.dgvData2.TabIndex = 0;
            this.dgvData2.DataSourceChanged += new System.EventHandler(this.dgvData2_DataSourceChanged);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.lblCount2});
            this.statusStrip2.Location = new System.Drawing.Point(3, 284);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(510, 22);
            this.statusStrip2.TabIndex = 2;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel2.Text = "Всего: ";
            // 
            // lblCount2
            // 
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(13, 17);
            this.lblCount2.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkNotFirm);
            this.groupBox2.Controls.Add(this.btnFilter2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 109);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Элементы фильтрации";
            // 
            // chkNotFirm
            // 
            this.chkNotFirm.AutoSize = true;
            this.chkNotFirm.Location = new System.Drawing.Point(6, 19);
            this.chkNotFirm.Name = "chkNotFirm";
            this.chkNotFirm.Size = new System.Drawing.Size(240, 17);
            this.chkNotFirm.TabIndex = 9;
            this.chkNotFirm.Text = "Исключить Фирмы из запроса на этапе 2";
            this.chkNotFirm.UseVisualStyleBackColor = true;
            // 
            // btnFilter2
            // 
            this.btnFilter2.Location = new System.Drawing.Point(385, 9);
            this.btnFilter2.Name = "btnFilter2";
            this.btnFilter2.Size = new System.Drawing.Size(125, 91);
            this.btnFilter2.TabIndex = 6;
            this.btnFilter2.Text = "Выполнить фильтрацию";
            this.btnFilter2.UseVisualStyleBackColor = true;
            this.btnFilter2.Click += new System.EventHandler(this.btnFilter2_Click);
            // 
            // frmTask1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTask1";
            this.Text = "Тестовое задание";
            this.Load += new System.EventHandler(this.frmTask1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpData1.ResumeLayout(false);
            this.grpData1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpFilter1.ResumeLayout(false);
            this.grpFilter1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData2)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpData1;
        private System.Windows.Forms.DataGridView dgvData1;
        private System.Windows.Forms.GroupBox grpFilter1;
        private System.Windows.Forms.CheckBox chkFirm;
        private System.Windows.Forms.CheckBox chkCity_Post;
        private System.Windows.Forms.CheckBox chkCity_Jur;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtCity_Jur;
        private System.Windows.Forms.TextBox txtCity_Post;
        private System.Windows.Forms.TextBox txtFirm;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvData2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkNotFirm;
        private System.Windows.Forms.Button btnFilter2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCount1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblCount2;
    }
}