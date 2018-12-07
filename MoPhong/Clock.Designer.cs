namespace MoPhong
{
    partial class Clock
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNumPage = new System.Windows.Forms.TextBox();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.tkbSpeed = new System.Windows.Forms.TrackBar();
            this.flpOld = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCurrentPage = new System.Windows.Forms.Panel();
            this.btnPause = new System.Windows.Forms.Button();
            this.flpStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCounter = new System.Windows.Forms.FlowLayoutPanel();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPageString = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRun = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSpeed)).BeginInit();
            this.pnlCurrentPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(661, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Trang mới:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Số khung:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tkbSpeed);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtInput);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtNumPage);
            this.panel1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 69);
            this.panel1.TabIndex = 64;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(483, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 38);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(264, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(53, 28);
            this.txtInput.TabIndex = 15;
            this.txtInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyUp);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(356, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 38);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNumPage
            // 
            this.txtNumPage.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPage.Location = new System.Drawing.Point(88, 14);
            this.txtNumPage.Name = "txtNumPage";
            this.txtNumPage.Size = new System.Drawing.Size(50, 28);
            this.txtNumPage.TabIndex = 12;
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPage.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(50, 50);
            this.lblCurrentPage.TabIndex = 0;
            this.lblCurrentPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tkbSpeed
            // 
            this.tkbSpeed.Location = new System.Drawing.Point(754, 14);
            this.tkbSpeed.Maximum = 100;
            this.tkbSpeed.Minimum = 1;
            this.tkbSpeed.Name = "tkbSpeed";
            this.tkbSpeed.Size = new System.Drawing.Size(81, 45);
            this.tkbSpeed.TabIndex = 66;
            this.tkbSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbSpeed.Value = 50;
            // 
            // flpOld
            // 
            this.flpOld.AutoSize = true;
            this.flpOld.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpOld.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpOld.Location = new System.Drawing.Point(537, 395);
            this.flpOld.Name = "flpOld";
            this.flpOld.Size = new System.Drawing.Size(50, 150);
            this.flpOld.TabIndex = 60;
            // 
            // pnlCurrentPage
            // 
            this.pnlCurrentPage.Controls.Add(this.lblCurrentPage);
            this.pnlCurrentPage.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCurrentPage.Location = new System.Drawing.Point(488, 395);
            this.pnlCurrentPage.Name = "pnlCurrentPage";
            this.pnlCurrentPage.Size = new System.Drawing.Size(50, 150);
            this.pnlCurrentPage.TabIndex = 63;
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(496, 153);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(91, 38);
            this.btnPause.TabIndex = 56;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // flpStatus
            // 
            this.flpStatus.AutoSize = true;
            this.flpStatus.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpStatus.Location = new System.Drawing.Point(211, 395);
            this.flpStatus.Name = "flpStatus";
            this.flpStatus.Size = new System.Drawing.Size(63, 150);
            this.flpStatus.TabIndex = 61;
            // 
            // flpCounter
            // 
            this.flpCounter.AutoSize = true;
            this.flpCounter.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCounter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpCounter.Location = new System.Drawing.Point(128, 395);
            this.flpCounter.Name = "flpCounter";
            this.flpCounter.Size = new System.Drawing.Size(50, 150);
            this.flpCounter.TabIndex = 62;
            // 
            // flpMain
            // 
            this.flpMain.AutoSize = true;
            this.flpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flpMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMain.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpMain.Location = new System.Drawing.Point(63, 193);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(900, 152);
            this.flpMain.TabIndex = 59;
            // 
            // flpPageString
            // 
            this.flpPageString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.flpPageString.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpPageString.Location = new System.Drawing.Point(63, 97);
            this.flpPageString.Name = "flpPageString";
            this.flpPageString.Size = new System.Drawing.Size(900, 50);
            this.flpPageString.TabIndex = 58;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(273, 153);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(102, 38);
            this.btnRun.TabIndex = 57;
            this.btnRun.Text = "Chạy";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 569);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 67;
            this.label4.Text = "Status bit";
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1011, 599);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpOld);
            this.Controls.Add(this.pnlCurrentPage);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.flpStatus);
            this.Controls.Add(this.flpCounter);
            this.Controls.Add(this.flpMain);
            this.Controls.Add(this.flpPageString);
            this.Controls.Add(this.btnRun);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clock";
            this.Text = "Clock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSpeed)).EndInit();
            this.pnlCurrentPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNumPage;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.TrackBar tkbSpeed;
        private System.Windows.Forms.FlowLayoutPanel flpOld;
        private System.Windows.Forms.Panel pnlCurrentPage;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.FlowLayoutPanel flpStatus;
        private System.Windows.Forms.FlowLayoutPanel flpCounter;
        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.FlowLayoutPanel flpPageString;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label4;
    }
}