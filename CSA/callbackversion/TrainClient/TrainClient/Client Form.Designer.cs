namespace TrainClient
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnSwitchTrack = new System.Windows.Forms.Button();
            this.btnStopTrain = new System.Windows.Forms.Button();
            this.btnWriteActuator = new System.Windows.Forms.Button();
            this.gbSwitchTrack = new System.Windows.Forms.GroupBox();
            this.cbSwitchState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.gbTrain = new System.Windows.Forms.GroupBox();
            this.tbRPM = new System.Windows.Forms.TextBox();
            this.lblActualSpeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRPM = new System.Windows.Forms.Label();
            this.lblState2 = new System.Windows.Forms.Label();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.tbDanger = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LdrReadClock = new System.Windows.Forms.Timer(this.components);
            this.subscribebtn = new System.Windows.Forms.Button();
            this.unsubscribebtn = new System.Windows.Forms.Button();
            this.gbLaserArray = new System.Windows.Forms.GroupBox();
            this.gbSwitchTrack.SuspendLayout();
            this.gbTrain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            this.gbLaserArray.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSwitchTrack
            // 
            this.btnSwitchTrack.Location = new System.Drawing.Point(6, 122);
            this.btnSwitchTrack.Name = "btnSwitchTrack";
            this.btnSwitchTrack.Size = new System.Drawing.Size(120, 47);
            this.btnSwitchTrack.TabIndex = 2;
            this.btnSwitchTrack.Text = "Switch Track";
            this.btnSwitchTrack.UseVisualStyleBackColor = true;
            this.btnSwitchTrack.Click += new System.EventHandler(this.btnSwitchTrack_Click);
            // 
            // btnStopTrain
            // 
            this.btnStopTrain.Location = new System.Drawing.Point(6, 94);
            this.btnStopTrain.Name = "btnStopTrain";
            this.btnStopTrain.Size = new System.Drawing.Size(142, 39);
            this.btnStopTrain.TabIndex = 3;
            this.btnStopTrain.Text = "Stop Train";
            this.btnStopTrain.UseVisualStyleBackColor = true;
            this.btnStopTrain.Click += new System.EventHandler(this.btnStopTrain_Click);
            // 
            // btnWriteActuator
            // 
            this.btnWriteActuator.Location = new System.Drawing.Point(165, 94);
            this.btnWriteActuator.Name = "btnWriteActuator";
            this.btnWriteActuator.Size = new System.Drawing.Size(76, 39);
            this.btnWriteActuator.TabIndex = 4;
            this.btnWriteActuator.Text = "Write Speed";
            this.btnWriteActuator.UseVisualStyleBackColor = true;
            this.btnWriteActuator.Click += new System.EventHandler(this.btnWriteActuator_Click_1);
            // 
            // gbSwitchTrack
            // 
            this.gbSwitchTrack.Controls.Add(this.cbSwitchState);
            this.gbSwitchTrack.Controls.Add(this.lblState);
            this.gbSwitchTrack.Controls.Add(this.btnSwitchTrack);
            this.gbSwitchTrack.Location = new System.Drawing.Point(267, 22);
            this.gbSwitchTrack.Name = "gbSwitchTrack";
            this.gbSwitchTrack.Size = new System.Drawing.Size(145, 179);
            this.gbSwitchTrack.TabIndex = 5;
            this.gbSwitchTrack.TabStop = false;
            this.gbSwitchTrack.Text = "Switch Track";
            this.gbSwitchTrack.Visible = false;
            // 
            // cbSwitchState
            // 
            this.cbSwitchState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSwitchState.FormattingEnabled = true;
            this.cbSwitchState.Location = new System.Drawing.Point(10, 85);
            this.cbSwitchState.Name = "cbSwitchState";
            this.cbSwitchState.Size = new System.Drawing.Size(121, 21);
            this.cbSwitchState.TabIndex = 8;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(7, 69);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "State";
            // 
            // gbTrain
            // 
            this.gbTrain.Controls.Add(this.tbRPM);
            this.gbTrain.Controls.Add(this.lblActualSpeed);
            this.gbTrain.Controls.Add(this.label4);
            this.gbTrain.Controls.Add(this.lblRPM);
            this.gbTrain.Controls.Add(this.btnWriteActuator);
            this.gbTrain.Controls.Add(this.lblState2);
            this.gbTrain.Controls.Add(this.numSpeed);
            this.gbTrain.Controls.Add(this.btnStopTrain);
            this.gbTrain.Location = new System.Drawing.Point(12, 12);
            this.gbTrain.Name = "gbTrain";
            this.gbTrain.Size = new System.Drawing.Size(249, 157);
            this.gbTrain.TabIndex = 6;
            this.gbTrain.TabStop = false;
            this.gbTrain.Text = "Train";
            // 
            // tbRPM
            // 
            this.tbRPM.Location = new System.Drawing.Point(97, 62);
            this.tbRPM.Name = "tbRPM";
            this.tbRPM.ReadOnly = true;
            this.tbRPM.Size = new System.Drawing.Size(59, 20);
            this.tbRPM.TabIndex = 12;
            // 
            // lblActualSpeed
            // 
            this.lblActualSpeed.AutoSize = true;
            this.lblActualSpeed.Location = new System.Drawing.Point(16, 65);
            this.lblActualSpeed.Name = "lblActualSpeed";
            this.lblActualSpeed.Size = new System.Drawing.Size(74, 13);
            this.lblActualSpeed.TabIndex = 11;
            this.lblActualSpeed.Text = "Actual Speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "RPM";
            // 
            // lblRPM
            // 
            this.lblRPM.AutoSize = true;
            this.lblRPM.Location = new System.Drawing.Point(162, 27);
            this.lblRPM.Name = "lblRPM";
            this.lblRPM.Size = new System.Drawing.Size(31, 13);
            this.lblRPM.TabIndex = 10;
            this.lblRPM.Text = "RPM";
            // 
            // lblState2
            // 
            this.lblState2.AutoSize = true;
            this.lblState2.Location = new System.Drawing.Point(16, 27);
            this.lblState2.Name = "lblState2";
            this.lblState2.Size = new System.Drawing.Size(41, 13);
            this.lblState2.TabIndex = 5;
            this.lblState2.Text = "Speed:";
            // 
            // numSpeed
            // 
            this.numSpeed.Location = new System.Drawing.Point(63, 25);
            this.numSpeed.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.numSpeed.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(93, 20);
            this.numSpeed.TabIndex = 9;
            this.numSpeed.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // tbDanger
            // 
            this.tbDanger.Location = new System.Drawing.Point(19, 35);
            this.tbDanger.Name = "tbDanger";
            this.tbDanger.ReadOnly = true;
            this.tbDanger.Size = new System.Drawing.Size(100, 20);
            this.tbDanger.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Real time Laser value:";
            // 
            // LdrReadClock
            // 
            this.LdrReadClock.Enabled = true;
            this.LdrReadClock.Interval = 500;
            this.LdrReadClock.Tick += new System.EventHandler(this.LdrReadClock_Tick);
            // 
            // subscribebtn
            // 
            this.subscribebtn.Location = new System.Drawing.Point(166, 206);
            this.subscribebtn.Name = "subscribebtn";
            this.subscribebtn.Size = new System.Drawing.Size(87, 23);
            this.subscribebtn.TabIndex = 11;
            this.subscribebtn.Text = "Subscribe";
            this.subscribebtn.UseVisualStyleBackColor = true;
            this.subscribebtn.Click += new System.EventHandler(this.subscribebtn_Click);
            // 
            // unsubscribebtn
            // 
            this.unsubscribebtn.Enabled = false;
            this.unsubscribebtn.Location = new System.Drawing.Point(166, 235);
            this.unsubscribebtn.Name = "unsubscribebtn";
            this.unsubscribebtn.Size = new System.Drawing.Size(87, 23);
            this.unsubscribebtn.TabIndex = 12;
            this.unsubscribebtn.Text = "Unsubscribe";
            this.unsubscribebtn.UseVisualStyleBackColor = true;
            this.unsubscribebtn.Click += new System.EventHandler(this.unsubscribebtn_Click);
            // 
            // gbLaserArray
            // 
            this.gbLaserArray.Controls.Add(this.tbDanger);
            this.gbLaserArray.Controls.Add(this.label3);
            this.gbLaserArray.Location = new System.Drawing.Point(12, 206);
            this.gbLaserArray.Name = "gbLaserArray";
            this.gbLaserArray.Size = new System.Drawing.Size(145, 72);
            this.gbLaserArray.TabIndex = 13;
            this.gbLaserArray.TabStop = false;
            this.gbLaserArray.Text = "Laser Array:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 301);
            this.Controls.Add(this.gbLaserArray);
            this.Controls.Add(this.unsubscribebtn);
            this.Controls.Add(this.subscribebtn);
            this.Controls.Add(this.gbTrain);
            this.Controls.Add(this.gbSwitchTrack);
            this.Name = "Form1";
            this.Text = "Train UI";
            this.gbSwitchTrack.ResumeLayout(false);
            this.gbSwitchTrack.PerformLayout();
            this.gbTrain.ResumeLayout(false);
            this.gbTrain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            this.gbLaserArray.ResumeLayout(false);
            this.gbLaserArray.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSwitchTrack;
        private System.Windows.Forms.Button btnStopTrain;
        private System.Windows.Forms.Button btnWriteActuator;
        private System.Windows.Forms.GroupBox gbSwitchTrack;
        private System.Windows.Forms.GroupBox gbTrain;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblState2;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDanger;
        internal System.Windows.Forms.Timer LdrReadClock;
        private System.Windows.Forms.Button subscribebtn;
        private System.Windows.Forms.Button unsubscribebtn;
        private System.Windows.Forms.ComboBox cbSwitchState;
        private System.Windows.Forms.Label lblActualSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRPM;
        private System.Windows.Forms.TextBox tbRPM;
        private System.Windows.Forms.GroupBox gbLaserArray;
    }
}

