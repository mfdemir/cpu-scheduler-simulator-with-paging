namespace CPU_Scheduler_Simulator
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.processesDataGrid = new System.Windows.Forms.DataGridView();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IBT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EBT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.stepsDataGrid = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelFIFOHitRatio = new System.Windows.Forms.Label();
            this.labelFIFOFault = new System.Windows.Forms.Label();
            this.labelFIFOHit = new System.Windows.Forms.Label();
            this.labelFIFOTotal = new System.Windows.Forms.Label();
            this.WSFIFODataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asdsad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelLRUHitRatio = new System.Windows.Forms.Label();
            this.WSLRUDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asdasd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelLRUFault = new System.Windows.Forms.Label();
            this.labelLRUTotal = new System.Windows.Forms.Label();
            this.labelLRUHit = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.buttonSetMLFQ = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxMLFQ = new System.Windows.Forms.ListBox();
            this.textBoxWorkingSetSize = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxPageCount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxProcessCount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxMaxBurstTime = new System.Windows.Forms.TextBox();
            this.textBoxMaxArrivalTime = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.buttonStep = new System.Windows.Forms.Button();
            this.buttonStepUntilDemand = new System.Windows.Forms.Button();
            this.buttonSimulate = new System.Windows.Forms.Button();
            this.LRUStackDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.processesDataGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsDataGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WSFIFODataGrid)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WSLRUDataGrid)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LRUStackDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // processesDataGrid
            // 
            this.processesDataGrid.AllowUserToAddRows = false;
            this.processesDataGrid.AllowUserToDeleteRows = false;
            this.processesDataGrid.AllowUserToResizeColumns = false;
            this.processesDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.processesDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.processesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.processesDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.processesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P,
            this.IBT,
            this.EBT,
            this.AT});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.processesDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.processesDataGrid.Location = new System.Drawing.Point(5, 18);
            this.processesDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.processesDataGrid.MultiSelect = false;
            this.processesDataGrid.Name = "processesDataGrid";
            this.processesDataGrid.ReadOnly = true;
            this.processesDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.processesDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.processesDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.processesDataGrid.RowTemplate.Height = 24;
            this.processesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.processesDataGrid.Size = new System.Drawing.Size(1031, 156);
            this.processesDataGrid.TabIndex = 2;
            // 
            // P
            // 
            this.P.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.P.FillWeight = 121.4158F;
            this.P.HeaderText = "P";
            this.P.Name = "P";
            this.P.ReadOnly = true;
            this.P.ToolTipText = "Process";
            this.P.Width = 25;
            // 
            // IBT
            // 
            this.IBT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IBT.FillWeight = 40.60914F;
            this.IBT.HeaderText = "IBT";
            this.IBT.Name = "IBT";
            this.IBT.ReadOnly = true;
            this.IBT.ToolTipText = "Initial Burst Time";
            this.IBT.Width = 30;
            // 
            // EBT
            // 
            this.EBT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EBT.FillWeight = 118.9875F;
            this.EBT.HeaderText = "EBT";
            this.EBT.Name = "EBT";
            this.EBT.ReadOnly = true;
            this.EBT.ToolTipText = "Elapsed Burst Time";
            this.EBT.Width = 30;
            // 
            // AT
            // 
            this.AT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AT.FillWeight = 118.9875F;
            this.AT.HeaderText = "AT";
            this.AT.Name = "AT";
            this.AT.ReadOnly = true;
            this.AT.ToolTipText = "Arrival Time";
            this.AT.Width = 30;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1296, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(1500, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // stepsDataGrid
            // 
            this.stepsDataGrid.AllowUserToAddRows = false;
            this.stepsDataGrid.AllowUserToDeleteRows = false;
            this.stepsDataGrid.AllowUserToResizeColumns = false;
            this.stepsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.stepsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.stepsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.stepsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stepsDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.stepsDataGrid.Location = new System.Drawing.Point(6, 19);
            this.stepsDataGrid.Name = "stepsDataGrid";
            this.stepsDataGrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stepsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.stepsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.stepsDataGrid.RowTemplate.ReadOnly = true;
            this.stepsDataGrid.Size = new System.Drawing.Size(1203, 98);
            this.stepsDataGrid.TabIndex = 5;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stepsDataGrid);
            this.groupBox3.Location = new System.Drawing.Point(12, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1216, 123);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gantt Chart";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.processesDataGrid);
            this.groupBox4.Location = new System.Drawing.Point(12, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1043, 177);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Processes";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelFIFOHitRatio);
            this.groupBox5.Controls.Add(this.labelFIFOFault);
            this.groupBox5.Controls.Add(this.labelFIFOHit);
            this.groupBox5.Controls.Add(this.labelFIFOTotal);
            this.groupBox5.Controls.Add(this.WSFIFODataGrid);
            this.groupBox5.Location = new System.Drawing.Point(1061, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(80, 267);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "WS (FIFO)";
            // 
            // labelFIFOHitRatio
            // 
            this.labelFIFOHitRatio.AutoSize = true;
            this.labelFIFOHitRatio.Location = new System.Drawing.Point(3, 249);
            this.labelFIFOHitRatio.Name = "labelFIFOHitRatio";
            this.labelFIFOHitRatio.Size = new System.Drawing.Size(51, 13);
            this.labelFIFOHitRatio.TabIndex = 6;
            this.labelFIFOHitRatio.Text = "Hit Ratio:";
            // 
            // labelFIFOFault
            // 
            this.labelFIFOFault.AutoSize = true;
            this.labelFIFOFault.Location = new System.Drawing.Point(3, 236);
            this.labelFIFOFault.Name = "labelFIFOFault";
            this.labelFIFOFault.Size = new System.Drawing.Size(33, 13);
            this.labelFIFOFault.TabIndex = 6;
            this.labelFIFOFault.Text = "Fault:";
            // 
            // labelFIFOHit
            // 
            this.labelFIFOHit.AutoSize = true;
            this.labelFIFOHit.Location = new System.Drawing.Point(3, 223);
            this.labelFIFOHit.Name = "labelFIFOHit";
            this.labelFIFOHit.Size = new System.Drawing.Size(23, 13);
            this.labelFIFOHit.TabIndex = 6;
            this.labelFIFOHit.Text = "Hit:";
            // 
            // labelFIFOTotal
            // 
            this.labelFIFOTotal.AutoSize = true;
            this.labelFIFOTotal.Location = new System.Drawing.Point(3, 210);
            this.labelFIFOTotal.Name = "labelFIFOTotal";
            this.labelFIFOTotal.Size = new System.Drawing.Size(48, 13);
            this.labelFIFOTotal.TabIndex = 6;
            this.labelFIFOTotal.Text = "Total D.:";
            // 
            // WSFIFODataGrid
            // 
            this.WSFIFODataGrid.AllowUserToAddRows = false;
            this.WSFIFODataGrid.AllowUserToDeleteRows = false;
            this.WSFIFODataGrid.AllowUserToResizeColumns = false;
            this.WSFIFODataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.WSFIFODataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.WSFIFODataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WSFIFODataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.WSFIFODataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WSFIFODataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.asdsad});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WSFIFODataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.WSFIFODataGrid.Location = new System.Drawing.Point(6, 19);
            this.WSFIFODataGrid.Name = "WSFIFODataGrid";
            this.WSFIFODataGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WSFIFODataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.WSFIFODataGrid.RowHeadersVisible = false;
            this.WSFIFODataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.WSFIFODataGrid.RowTemplate.ReadOnly = true;
            this.WSFIFODataGrid.Size = new System.Drawing.Size(68, 185);
            this.WSFIFODataGrid.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#Page";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // asdsad
            // 
            this.asdsad.HeaderText = "Step";
            this.asdsad.Name = "asdsad";
            this.asdsad.ReadOnly = true;
            this.asdsad.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelLRUHitRatio);
            this.groupBox6.Controls.Add(this.WSLRUDataGrid);
            this.groupBox6.Controls.Add(this.labelLRUFault);
            this.groupBox6.Controls.Add(this.labelLRUTotal);
            this.groupBox6.Controls.Add(this.labelLRUHit);
            this.groupBox6.Location = new System.Drawing.Point(1147, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(81, 267);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "WS (LRU)";
            // 
            // labelLRUHitRatio
            // 
            this.labelLRUHitRatio.AutoSize = true;
            this.labelLRUHitRatio.Location = new System.Drawing.Point(3, 249);
            this.labelLRUHitRatio.Name = "labelLRUHitRatio";
            this.labelLRUHitRatio.Size = new System.Drawing.Size(51, 13);
            this.labelLRUHitRatio.TabIndex = 6;
            this.labelLRUHitRatio.Text = "Hit Ratio:";
            // 
            // WSLRUDataGrid
            // 
            this.WSLRUDataGrid.AllowUserToAddRows = false;
            this.WSLRUDataGrid.AllowUserToDeleteRows = false;
            this.WSLRUDataGrid.AllowUserToResizeColumns = false;
            this.WSLRUDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.WSLRUDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.WSLRUDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WSLRUDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.WSLRUDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WSLRUDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.asdasd});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WSLRUDataGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.WSLRUDataGrid.Location = new System.Drawing.Point(6, 19);
            this.WSLRUDataGrid.Name = "WSLRUDataGrid";
            this.WSLRUDataGrid.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WSLRUDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.WSLRUDataGrid.RowHeadersVisible = false;
            this.WSLRUDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.WSLRUDataGrid.RowTemplate.ReadOnly = true;
            this.WSLRUDataGrid.Size = new System.Drawing.Size(68, 185);
            this.WSLRUDataGrid.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "#Page";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // asdasd
            // 
            this.asdasd.HeaderText = "Step";
            this.asdasd.Name = "asdasd";
            this.asdasd.ReadOnly = true;
            this.asdasd.Visible = false;
            // 
            // labelLRUFault
            // 
            this.labelLRUFault.AutoSize = true;
            this.labelLRUFault.Location = new System.Drawing.Point(3, 236);
            this.labelLRUFault.Name = "labelLRUFault";
            this.labelLRUFault.Size = new System.Drawing.Size(33, 13);
            this.labelLRUFault.TabIndex = 6;
            this.labelLRUFault.Text = "Fault:";
            // 
            // labelLRUTotal
            // 
            this.labelLRUTotal.AutoSize = true;
            this.labelLRUTotal.Location = new System.Drawing.Point(3, 211);
            this.labelLRUTotal.Name = "labelLRUTotal";
            this.labelLRUTotal.Size = new System.Drawing.Size(48, 13);
            this.labelLRUTotal.TabIndex = 6;
            this.labelLRUTotal.Text = "Total D.:";
            // 
            // labelLRUHit
            // 
            this.labelLRUHit.AutoSize = true;
            this.labelLRUHit.Location = new System.Drawing.Point(3, 223);
            this.labelLRUHit.Name = "labelLRUHit";
            this.labelLRUHit.Size = new System.Drawing.Size(23, 13);
            this.labelLRUHit.TabIndex = 6;
            this.labelLRUHit.Text = "Hit:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.buttonSetMLFQ);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.listBoxMLFQ);
            this.groupBox7.Controls.Add(this.textBoxWorkingSetSize);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.textBoxPageCount);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.textBoxProcessCount);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.textBoxMaxBurstTime);
            this.groupBox7.Controls.Add(this.textBoxMaxArrivalTime);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Location = new System.Drawing.Point(12, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(522, 82);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Generator";
            // 
            // buttonSetMLFQ
            // 
            this.buttonSetMLFQ.Location = new System.Drawing.Point(276, 15);
            this.buttonSetMLFQ.Name = "buttonSetMLFQ";
            this.buttonSetMLFQ.Size = new System.Drawing.Size(131, 20);
            this.buttonSetMLFQ.TabIndex = 13;
            this.buttonSetMLFQ.Text = "Set MLFQ";
            this.buttonSetMLFQ.UseVisualStyleBackColor = true;
            this.buttonSetMLFQ.Click += new System.EventHandler(this.buttonSetMLFQ_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(140, 40);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Working Set Size:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 64);
            this.button2.TabIndex = 9;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // listBoxMLFQ
            // 
            this.listBoxMLFQ.FormattingEnabled = true;
            this.listBoxMLFQ.Items.AddRange(new object[] {
            "Null",
            "Null",
            "Null"});
            this.listBoxMLFQ.Location = new System.Drawing.Point(276, 36);
            this.listBoxMLFQ.Name = "listBoxMLFQ";
            this.listBoxMLFQ.Size = new System.Drawing.Size(131, 43);
            this.listBoxMLFQ.TabIndex = 12;
            // 
            // textBoxWorkingSetSize
            // 
            this.textBoxWorkingSetSize.Location = new System.Drawing.Point(242, 37);
            this.textBoxWorkingSetSize.Name = "textBoxWorkingSetSize";
            this.textBoxWorkingSetSize.Size = new System.Drawing.Size(28, 20);
            this.textBoxWorkingSetSize.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(140, 18);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Page Count:";
            // 
            // textBoxPageCount
            // 
            this.textBoxPageCount.Location = new System.Drawing.Point(242, 15);
            this.textBoxPageCount.Name = "textBoxPageCount";
            this.textBoxPageCount.Size = new System.Drawing.Size(28, 20);
            this.textBoxPageCount.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 18);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Process Count:";
            // 
            // textBoxProcessCount
            // 
            this.textBoxProcessCount.Location = new System.Drawing.Point(107, 15);
            this.textBoxProcessCount.Name = "textBoxProcessCount";
            this.textBoxProcessCount.Size = new System.Drawing.Size(28, 20);
            this.textBoxProcessCount.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 40);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Max Burst Time:";
            // 
            // textBoxMaxBurstTime
            // 
            this.textBoxMaxBurstTime.Location = new System.Drawing.Point(107, 37);
            this.textBoxMaxBurstTime.Name = "textBoxMaxBurstTime";
            this.textBoxMaxBurstTime.Size = new System.Drawing.Size(28, 20);
            this.textBoxMaxBurstTime.TabIndex = 11;
            // 
            // textBoxMaxArrivalTime
            // 
            this.textBoxMaxArrivalTime.Location = new System.Drawing.Point(107, 59);
            this.textBoxMaxArrivalTime.Name = "textBoxMaxArrivalTime";
            this.textBoxMaxArrivalTime.Size = new System.Drawing.Size(28, 20);
            this.textBoxMaxArrivalTime.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 62);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Max Arrival Time:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.buttonStep);
            this.groupBox8.Controls.Add(this.buttonStepUntilDemand);
            this.groupBox8.Controls.Add(this.buttonSimulate);
            this.groupBox8.Location = new System.Drawing.Point(540, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(280, 82);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Simulation";
            // 
            // buttonStep
            // 
            this.buttonStep.Enabled = false;
            this.buttonStep.Location = new System.Drawing.Point(8, 19);
            this.buttonStep.Name = "buttonStep";
            this.buttonStep.Size = new System.Drawing.Size(129, 23);
            this.buttonStep.TabIndex = 6;
            this.buttonStep.Text = "Simulate One Step";
            this.buttonStep.UseVisualStyleBackColor = true;
            this.buttonStep.Click += new System.EventHandler(this.buttonStep_Click);
            // 
            // buttonStepUntilDemand
            // 
            this.buttonStepUntilDemand.Enabled = false;
            this.buttonStepUntilDemand.Location = new System.Drawing.Point(143, 19);
            this.buttonStepUntilDemand.Name = "buttonStepUntilDemand";
            this.buttonStepUntilDemand.Size = new System.Drawing.Size(129, 52);
            this.buttonStepUntilDemand.TabIndex = 8;
            this.buttonStepUntilDemand.Text = "Simulate Till Next Demand";
            this.buttonStepUntilDemand.UseVisualStyleBackColor = true;
            this.buttonStepUntilDemand.Click += new System.EventHandler(this.buttonStepUntilDemand_Click);
            // 
            // buttonSimulate
            // 
            this.buttonSimulate.Enabled = false;
            this.buttonSimulate.Location = new System.Drawing.Point(8, 48);
            this.buttonSimulate.Name = "buttonSimulate";
            this.buttonSimulate.Size = new System.Drawing.Size(129, 23);
            this.buttonSimulate.TabIndex = 8;
            this.buttonSimulate.Text = "SimulateTill The End";
            this.buttonSimulate.UseVisualStyleBackColor = true;
            this.buttonSimulate.Click += new System.EventHandler(this.buttonSimulate_Click);
            // 
            // LRUStackDataGrid
            // 
            this.LRUStackDataGrid.AllowUserToAddRows = false;
            this.LRUStackDataGrid.AllowUserToDeleteRows = false;
            this.LRUStackDataGrid.AllowUserToResizeColumns = false;
            this.LRUStackDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.LRUStackDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.LRUStackDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LRUStackDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.LRUStackDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LRUStackDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LRUStackDataGrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.LRUStackDataGrid.Location = new System.Drawing.Point(1234, 12);
            this.LRUStackDataGrid.Name = "LRUStackDataGrid";
            this.LRUStackDataGrid.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LRUStackDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.LRUStackDataGrid.RowHeadersVisible = false;
            this.LRUStackDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.LRUStackDataGrid.RowTemplate.ReadOnly = true;
            this.LRUStackDataGrid.Size = new System.Drawing.Size(55, 390);
            this.LRUStackDataGrid.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Stack";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Step";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 433);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.LRUStackDataGrid);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "CPU Scheduler Simulator With Paging";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processesDataGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsDataGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WSFIFODataGrid)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WSLRUDataGrid)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LRUStackDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView processesDataGrid;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView stepsDataGrid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView WSFIFODataGrid;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView WSLRUDataGrid;
        private System.Windows.Forms.Label labelFIFOHitRatio;
        private System.Windows.Forms.Label labelFIFOFault;
        private System.Windows.Forms.Label labelFIFOHit;
        private System.Windows.Forms.Label labelFIFOTotal;
        private System.Windows.Forms.Label labelLRUHitRatio;
        private System.Windows.Forms.Label labelLRUFault;
        private System.Windows.Forms.Label labelLRUTotal;
        private System.Windows.Forms.Label labelLRUHit;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonSetMLFQ;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxMLFQ;
        private System.Windows.Forms.TextBox textBoxWorkingSetSize;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxPageCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxProcessCount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxMaxBurstTime;
        private System.Windows.Forms.TextBox textBoxMaxArrivalTime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button buttonStep;
        private System.Windows.Forms.Button buttonSimulate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn asdsad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn asdasd;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn IBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn EBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn AT;
        private System.Windows.Forms.Button buttonStepUntilDemand;
        private System.Windows.Forms.DataGridView LRUStackDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

