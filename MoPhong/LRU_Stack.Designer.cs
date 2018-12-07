namespace MoPhong
{
    partial class LRU_Stack
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
            this.tkbSpeed = new System.Windows.Forms.TrackBar();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.Counter = new System.Windows.Forms.Label();
            this.pnlCal = new System.Windows.Forms.Panel();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.pnlCurrentPage = new System.Windows.Forms.Panel();
            this.lblCurentPage = new System.Windows.Forms.Label();
            this.flpOld = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCounter = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtNumPage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.flpPageString = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSpeed)).BeginInit();
            this.pnlCal.SuspendLayout();
            this.pnlCurrentPage.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tkbSpeed
            // 
            this.tkbSpeed.Location = new System.Drawing.Point(853, 12);
            this.tkbSpeed.Maximum = 100;
            this.tkbSpeed.Minimum = 1;
            this.tkbSpeed.Name = "tkbSpeed";
            this.tkbSpeed.Size = new System.Drawing.Size(104, 45);
            this.tkbSpeed.TabIndex = 66;
            this.tkbSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbSpeed.Value = 25;
            this.tkbSpeed.ValueChanged += new System.EventHandler(this.tkbSpeed_ValueChanged);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(574, 178);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(211, 39);
            this.btnPause.TabIndex = 64;
            this.btnPause.Text = "Stop";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(157, 178);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(211, 38);
            this.btnRun.TabIndex = 65;
            this.btnRun.Text = "Start";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // flpMain
            // 
            this.flpMain.AutoSize = true;
            this.flpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flpMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMain.Location = new System.Drawing.Point(21, 222);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(900, 140);
            this.flpMain.TabIndex = 62;
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter.Location = new System.Drawing.Point(56, 206);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(51, 21);
            this.Counter.TabIndex = 42;
            this.Counter.Text = "Stack";
            // 
            // pnlCal
            // 
            this.pnlCal.AutoSize = true;
            this.pnlCal.Controls.Add(this.lblCurrentPage);
            this.pnlCal.Controls.Add(this.pnlCurrentPage);
            this.pnlCal.Controls.Add(this.flpOld);
            this.pnlCal.Controls.Add(this.Counter);
            this.pnlCal.Controls.Add(this.flpCounter);
            this.pnlCal.Location = new System.Drawing.Point(21, 368);
            this.pnlCal.Name = "pnlCal";
            this.pnlCal.Size = new System.Drawing.Size(902, 244);
            this.pnlCal.TabIndex = 68;
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPage.Location = new System.Drawing.Point(51, -115);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(50, 50);
            this.lblCurrentPage.TabIndex = 42;
            this.lblCurrentPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCurrentPage
            // 
            this.pnlCurrentPage.Controls.Add(this.lblCurentPage);
            this.pnlCurrentPage.Location = new System.Drawing.Point(242, 37);
            this.pnlCurrentPage.Name = "pnlCurrentPage";
            this.pnlCurrentPage.Size = new System.Drawing.Size(50, 150);
            this.pnlCurrentPage.TabIndex = 40;
            // 
            // lblCurentPage
            // 
            this.lblCurentPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurentPage.Location = new System.Drawing.Point(0, 0);
            this.lblCurentPage.Name = "lblCurentPage";
            this.lblCurentPage.Size = new System.Drawing.Size(50, 50);
            this.lblCurentPage.TabIndex = 41;
            this.lblCurentPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpOld
            // 
            this.flpOld.AutoSize = true;
            this.flpOld.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpOld.Location = new System.Drawing.Point(298, 37);
            this.flpOld.Name = "flpOld";
            this.flpOld.Size = new System.Drawing.Size(60, 150);
            this.flpOld.TabIndex = 38;
            // 
            // flpCounter
            // 
            this.flpCounter.AutoSize = true;
            this.flpCounter.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flpCounter.Location = new System.Drawing.Point(60, 37);
            this.flpCounter.Name = "flpCounter";
            this.flpCounter.Size = new System.Drawing.Size(50, 150);
            this.flpCounter.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số khung:";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(514, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 35);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(636, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 35);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtNumPage
            // 
            this.txtNumPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPage.Location = new System.Drawing.Point(201, 13);
            this.txtNumPage.Name = "txtNumPage";
            this.txtNumPage.Size = new System.Drawing.Size(45, 30);
            this.txtNumPage.TabIndex = 36;
            this.txtNumPage.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trang mới";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(391, 7);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(45, 38);
            this.txtInput.TabIndex = 37;
            this.txtInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyUp);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlHeader.Controls.Add(this.tkbSpeed);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.btnAdd);
            this.pnlHeader.Controls.Add(this.btnDelete);
            this.pnlHeader.Controls.Add(this.txtNumPage);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.txtInput);
            this.pnlHeader.Location = new System.Drawing.Point(2, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(960, 56);
            this.pnlHeader.TabIndex = 67;
            // 
            // flpPageString
            // 
            this.flpPageString.AutoSize = true;
            this.flpPageString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.flpPageString.Location = new System.Drawing.Point(2, 75);
            this.flpPageString.Name = "flpPageString";
            this.flpPageString.Size = new System.Drawing.Size(957, 50);
            this.flpPageString.TabIndex = 61;
            // 
            // LRU_Stack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(954, 634);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.flpMain);
            this.Controls.Add(this.pnlCal);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.flpPageString);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LRU_Stack";
            this.Text = "LRU_Stack";
            ((System.ComponentModel.ISupportInitialize)(this.tkbSpeed)).EndInit();
            this.pnlCal.ResumeLayout(false);
            this.pnlCal.PerformLayout();
            this.pnlCurrentPage.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tkbSpeed;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Panel pnlCal;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Panel pnlCurrentPage;
        private System.Windows.Forms.Label lblCurentPage;
        private System.Windows.Forms.FlowLayoutPanel flpOld;
        private System.Windows.Forms.FlowLayoutPanel flpCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtNumPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.FlowLayoutPanel flpPageString;
    }
}