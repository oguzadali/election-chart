
namespace election_chart
{
    partial class FormCharts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartVote = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSelectState = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarXP = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarYP = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarAP = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBarTP = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBarCP = new System.Windows.Forms.ProgressBar();
            this.labelXP = new System.Windows.Forms.Label();
            this.labelYP = new System.Windows.Forms.Label();
            this.labelAP = new System.Windows.Forms.Label();
            this.labelTP = new System.Windows.Forms.Label();
            this.labelCP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBarInvalid = new System.Windows.Forms.ProgressBar();
            this.labelInvalid = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVote)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartVote);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sum Vote Chart";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelInvalid);
            this.groupBox2.Controls.Add(this.labelCP);
            this.groupBox2.Controls.Add(this.labelTP);
            this.groupBox2.Controls.Add(this.labelAP);
            this.groupBox2.Controls.Add(this.labelYP);
            this.groupBox2.Controls.Add(this.labelXP);
            this.groupBox2.Controls.Add(this.progressBarInvalid);
            this.groupBox2.Controls.Add(this.progressBarCP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.progressBarTP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.progressBarAP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.progressBarYP);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.progressBarXP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxSelectState);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(23, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 313);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Local Statistic";
            // 
            // chartVote
            // 
            chartArea3.Name = "ChartArea1";
            this.chartVote.ChartAreas.Add(chartArea3);
            this.chartVote.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartVote.Legends.Add(legend3);
            this.chartVote.Location = new System.Drawing.Point(3, 18);
            this.chartVote.Name = "chartVote";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Partys";
            this.chartVote.Series.Add(series3);
            this.chartVote.Size = new System.Drawing.Size(694, 262);
            this.chartVote.TabIndex = 0;
            this.chartVote.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT STATE:";
            // 
            // comboBoxSelectState
            // 
            this.comboBoxSelectState.FormattingEnabled = true;
            this.comboBoxSelectState.Location = new System.Drawing.Point(214, 37);
            this.comboBoxSelectState.Name = "comboBoxSelectState";
            this.comboBoxSelectState.Size = new System.Drawing.Size(260, 24);
            this.comboBoxSelectState.TabIndex = 1;
            this.comboBoxSelectState.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectState_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "X PARTY:";
            // 
            // progressBarXP
            // 
            this.progressBarXP.Location = new System.Drawing.Point(214, 80);
            this.progressBarXP.Maximum = 300;
            this.progressBarXP.Name = "progressBarXP";
            this.progressBarXP.Size = new System.Drawing.Size(260, 23);
            this.progressBarXP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y PARTY:";
            // 
            // progressBarYP
            // 
            this.progressBarYP.Location = new System.Drawing.Point(214, 118);
            this.progressBarYP.Maximum = 300;
            this.progressBarYP.Name = "progressBarYP";
            this.progressBarYP.Size = new System.Drawing.Size(260, 23);
            this.progressBarYP.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "A PARTY:";
            // 
            // progressBarAP
            // 
            this.progressBarAP.Location = new System.Drawing.Point(214, 156);
            this.progressBarAP.Maximum = 300;
            this.progressBarAP.Name = "progressBarAP";
            this.progressBarAP.Size = new System.Drawing.Size(260, 23);
            this.progressBarAP.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "T PARTY:";
            // 
            // progressBarTP
            // 
            this.progressBarTP.Location = new System.Drawing.Point(214, 195);
            this.progressBarTP.Maximum = 300;
            this.progressBarTP.Name = "progressBarTP";
            this.progressBarTP.Size = new System.Drawing.Size(260, 23);
            this.progressBarTP.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "C PARTY:";
            // 
            // progressBarCP
            // 
            this.progressBarCP.Location = new System.Drawing.Point(214, 232);
            this.progressBarCP.Maximum = 300;
            this.progressBarCP.Name = "progressBarCP";
            this.progressBarCP.Size = new System.Drawing.Size(260, 23);
            this.progressBarCP.TabIndex = 2;
            // 
            // labelXP
            // 
            this.labelXP.AutoSize = true;
            this.labelXP.Location = new System.Drawing.Point(497, 86);
            this.labelXP.Name = "labelXP";
            this.labelXP.Size = new System.Drawing.Size(16, 17);
            this.labelXP.TabIndex = 3;
            this.labelXP.Text = "0";
            // 
            // labelYP
            // 
            this.labelYP.AutoSize = true;
            this.labelYP.Location = new System.Drawing.Point(497, 124);
            this.labelYP.Name = "labelYP";
            this.labelYP.Size = new System.Drawing.Size(16, 17);
            this.labelYP.TabIndex = 3;
            this.labelYP.Text = "0";
            // 
            // labelAP
            // 
            this.labelAP.AutoSize = true;
            this.labelAP.Location = new System.Drawing.Point(497, 162);
            this.labelAP.Name = "labelAP";
            this.labelAP.Size = new System.Drawing.Size(16, 17);
            this.labelAP.TabIndex = 3;
            this.labelAP.Text = "0";
            // 
            // labelTP
            // 
            this.labelTP.AutoSize = true;
            this.labelTP.Location = new System.Drawing.Point(497, 201);
            this.labelTP.Name = "labelTP";
            this.labelTP.Size = new System.Drawing.Size(16, 17);
            this.labelTP.TabIndex = 3;
            this.labelTP.Text = "0";
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(497, 238);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(16, 17);
            this.labelCP.TabIndex = 3;
            this.labelCP.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "INVALID VOTES:";
            // 
            // progressBarInvalid
            // 
            this.progressBarInvalid.Location = new System.Drawing.Point(214, 270);
            this.progressBarInvalid.Maximum = 300;
            this.progressBarInvalid.Name = "progressBarInvalid";
            this.progressBarInvalid.Size = new System.Drawing.Size(260, 23);
            this.progressBarInvalid.TabIndex = 2;
            // 
            // labelInvalid
            // 
            this.labelInvalid.AutoSize = true;
            this.labelInvalid.Location = new System.Drawing.Point(497, 276);
            this.labelInvalid.Name = "labelInvalid";
            this.labelInvalid.Size = new System.Drawing.Size(16, 17);
            this.labelInvalid.TabIndex = 3;
            this.labelInvalid.Text = "0";
            // 
            // FormCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(748, 645);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCharts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Election Chart";
            this.Load += new System.EventHandler(this.FormCharts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVote;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBarTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBarAP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBarYP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarXP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSelectState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarCP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.Label labelTP;
        private System.Windows.Forms.Label labelAP;
        private System.Windows.Forms.Label labelYP;
        private System.Windows.Forms.Label labelXP;
        private System.Windows.Forms.Label labelInvalid;
        private System.Windows.Forms.ProgressBar progressBarInvalid;
        private System.Windows.Forms.Label label7;
    }
}