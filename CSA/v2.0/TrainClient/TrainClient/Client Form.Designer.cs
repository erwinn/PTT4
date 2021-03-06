﻿namespace TrainClient
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
            this.lblSwitchState = new System.Windows.Forms.Label();
            this.lblSwitchID = new System.Windows.Forms.Label();
            this.tbSwitchID = new System.Windows.Forms.TextBox();
            this.gbStopTrain = new System.Windows.Forms.GroupBox();
            this.btnStartTrain = new System.Windows.Forms.Button();
            this.lblTrainID2 = new System.Windows.Forms.Label();
            this.tbTrainID2 = new System.Windows.Forms.TextBox();
            this.gbWriteSensorState = new System.Windows.Forms.GroupBox();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.tbActuatorId = new System.Windows.Forms.TextBox();
            this.lblSensor = new System.Windows.Forms.Label();
            this.lblState2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDanger = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbReadTimeLdr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSensorValue = new System.Windows.Forms.TextBox();
            this.tbSensorId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadSensor = new System.Windows.Forms.Button();
            this.LdrReadClock = new System.Windows.Forms.Timer(this.components);
            this.cbSwitchState = new System.Windows.Forms.ComboBox();
            this.gbSwitchTrack.SuspendLayout();
            this.gbStopTrain.SuspendLayout();
            this.gbWriteSensorState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSwitchTrack
            // 
            this.btnSwitchTrack.Location = new System.Drawing.Point(6, 189);
            this.btnSwitchTrack.Name = "btnSwitchTrack";
            this.btnSwitchTrack.Size = new System.Drawing.Size(120, 47);
            this.btnSwitchTrack.TabIndex = 2;
            this.btnSwitchTrack.Text = "Switch Track";
            this.btnSwitchTrack.UseVisualStyleBackColor = true;
            this.btnSwitchTrack.Click += new System.EventHandler(this.btnSwitchTrack_Click);
            // 
            // btnStopTrain
            // 
            this.btnStopTrain.Location = new System.Drawing.Point(6, 189);
            this.btnStopTrain.Name = "btnStopTrain";
            this.btnStopTrain.Size = new System.Drawing.Size(120, 47);
            this.btnStopTrain.TabIndex = 3;
            this.btnStopTrain.Text = "Stop Train";
            this.btnStopTrain.UseVisualStyleBackColor = true;
            this.btnStopTrain.Click += new System.EventHandler(this.btnStopTrain_Click);
            // 
            // btnWriteActuator
            // 
            this.btnWriteActuator.Location = new System.Drawing.Point(6, 189);
            this.btnWriteActuator.Name = "btnWriteActuator";
            this.btnWriteActuator.Size = new System.Drawing.Size(120, 47);
            this.btnWriteActuator.TabIndex = 4;
            this.btnWriteActuator.Text = "Write Speed";
            this.btnWriteActuator.UseVisualStyleBackColor = true;
            this.btnWriteActuator.Click += new System.EventHandler(this.btnWriteActuator_Click_1);
            // 
            // gbSwitchTrack
            // 
            this.gbSwitchTrack.Controls.Add(this.cbSwitchState);
            this.gbSwitchTrack.Controls.Add(this.lblSwitchState);
            this.gbSwitchTrack.Controls.Add(this.lblSwitchID);
            this.gbSwitchTrack.Controls.Add(this.tbSwitchID);
            this.gbSwitchTrack.Controls.Add(this.btnSwitchTrack);
            this.gbSwitchTrack.Location = new System.Drawing.Point(42, 36);
            this.gbSwitchTrack.Name = "gbSwitchTrack";
            this.gbSwitchTrack.Size = new System.Drawing.Size(179, 242);
            this.gbSwitchTrack.TabIndex = 5;
            this.gbSwitchTrack.TabStop = false;
            this.gbSwitchTrack.Text = "Switch Track";
            // 
            // lblSwitchState
            // 
            this.lblSwitchState.AutoSize = true;
            this.lblSwitchState.Location = new System.Drawing.Point(10, 128);
            this.lblSwitchState.Name = "lblSwitchState";
            this.lblSwitchState.Size = new System.Drawing.Size(32, 13);
            this.lblSwitchState.TabIndex = 6;
            this.lblSwitchState.Text = "State";
            // 
            // lblSwitchID
            // 
            this.lblSwitchID.AutoSize = true;
            this.lblSwitchID.Location = new System.Drawing.Point(7, 52);
            this.lblSwitchID.Name = "lblSwitchID";
            this.lblSwitchID.Size = new System.Drawing.Size(53, 13);
            this.lblSwitchID.TabIndex = 5;
            this.lblSwitchID.Text = "Switch ID";
            // 
            // tbSwitchID
            // 
            this.tbSwitchID.Location = new System.Drawing.Point(6, 71);
            this.tbSwitchID.Name = "tbSwitchID";
            this.tbSwitchID.Size = new System.Drawing.Size(100, 20);
            this.tbSwitchID.TabIndex = 3;
            // 
            // gbStopTrain
            // 
            this.gbStopTrain.Controls.Add(this.btnStartTrain);
            this.gbStopTrain.Controls.Add(this.lblTrainID2);
            this.gbStopTrain.Controls.Add(this.tbTrainID2);
            this.gbStopTrain.Controls.Add(this.btnStopTrain);
            this.gbStopTrain.Location = new System.Drawing.Point(274, 36);
            this.gbStopTrain.Name = "gbStopTrain";
            this.gbStopTrain.Size = new System.Drawing.Size(249, 242);
            this.gbStopTrain.TabIndex = 6;
            this.gbStopTrain.TabStop = false;
            this.gbStopTrain.Text = "Stop Train";
            // 
            // btnStartTrain
            // 
            this.btnStartTrain.Location = new System.Drawing.Point(132, 189);
            this.btnStartTrain.Name = "btnStartTrain";
            this.btnStartTrain.Size = new System.Drawing.Size(111, 47);
            this.btnStartTrain.TabIndex = 6;
            this.btnStartTrain.Text = "Start Train";
            this.btnStartTrain.UseVisualStyleBackColor = true;
            this.btnStartTrain.Click += new System.EventHandler(this.btnStartTrain_Click);
            // 
            // lblTrainID2
            // 
            this.lblTrainID2.AutoSize = true;
            this.lblTrainID2.Location = new System.Drawing.Point(93, 89);
            this.lblTrainID2.Name = "lblTrainID2";
            this.lblTrainID2.Size = new System.Drawing.Size(45, 13);
            this.lblTrainID2.TabIndex = 5;
            this.lblTrainID2.Text = "Train ID";
            // 
            // tbTrainID2
            // 
            this.tbTrainID2.Location = new System.Drawing.Point(70, 128);
            this.tbTrainID2.Name = "tbTrainID2";
            this.tbTrainID2.Size = new System.Drawing.Size(100, 20);
            this.tbTrainID2.TabIndex = 4;
            this.tbTrainID2.Text = "1";
            // 
            // gbWriteSensorState
            // 
            this.gbWriteSensorState.Controls.Add(this.numSpeed);
            this.gbWriteSensorState.Controls.Add(this.tbActuatorId);
            this.gbWriteSensorState.Controls.Add(this.lblSensor);
            this.gbWriteSensorState.Controls.Add(this.lblState2);
            this.gbWriteSensorState.Controls.Add(this.btnWriteActuator);
            this.gbWriteSensorState.Location = new System.Drawing.Point(529, 36);
            this.gbWriteSensorState.Name = "gbWriteSensorState";
            this.gbWriteSensorState.Size = new System.Drawing.Size(189, 242);
            this.gbWriteSensorState.TabIndex = 7;
            this.gbWriteSensorState.TabStop = false;
            this.gbWriteSensorState.Text = "Write Actuator Value";
            // 
            // numSpeed
            // 
            this.numSpeed.Location = new System.Drawing.Point(8, 100);
            this.numSpeed.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(120, 20);
            this.numSpeed.TabIndex = 9;
            this.numSpeed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // tbActuatorId
            // 
            this.tbActuatorId.Location = new System.Drawing.Point(8, 52);
            this.tbActuatorId.Name = "tbActuatorId";
            this.tbActuatorId.Size = new System.Drawing.Size(100, 20);
            this.tbActuatorId.TabIndex = 8;
            this.tbActuatorId.Text = "1";
            // 
            // lblSensor
            // 
            this.lblSensor.AutoSize = true;
            this.lblSensor.Location = new System.Drawing.Point(6, 36);
            this.lblSensor.Name = "lblSensor";
            this.lblSensor.Size = new System.Drawing.Size(64, 13);
            this.lblSensor.TabIndex = 6;
            this.lblSensor.Text = "Actuator ID:";
            // 
            // lblState2
            // 
            this.lblState2.AutoSize = true;
            this.lblState2.Location = new System.Drawing.Point(2, 83);
            this.lblState2.Name = "lblState2";
            this.lblState2.Size = new System.Drawing.Size(38, 13);
            this.lblState2.TabIndex = 5;
            this.lblState2.Text = "Speed";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDanger);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbReadTimeLdr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbSensorValue);
            this.groupBox1.Controls.Add(this.tbSensorId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnReadSensor);
            this.groupBox1.Location = new System.Drawing.Point(724, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 242);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read Sensor";
            // 
            // tbDanger
            // 
            this.tbDanger.Enabled = false;
            this.tbDanger.Location = new System.Drawing.Point(6, 215);
            this.tbDanger.Name = "tbDanger";
            this.tbDanger.Size = new System.Drawing.Size(100, 20);
            this.tbDanger.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Real time LDR value";
            // 
            // tbReadTimeLdr
            // 
            this.tbReadTimeLdr.Enabled = false;
            this.tbReadTimeLdr.Location = new System.Drawing.Point(6, 189);
            this.tbReadTimeLdr.Name = "tbReadTimeLdr";
            this.tbReadTimeLdr.Size = new System.Drawing.Size(100, 20);
            this.tbReadTimeLdr.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sensor Value";
            // 
            // tbSensorValue
            // 
            this.tbSensorValue.Enabled = false;
            this.tbSensorValue.Location = new System.Drawing.Point(9, 94);
            this.tbSensorValue.Name = "tbSensorValue";
            this.tbSensorValue.Size = new System.Drawing.Size(100, 20);
            this.tbSensorValue.TabIndex = 9;
            // 
            // tbSensorId
            // 
            this.tbSensorId.Location = new System.Drawing.Point(8, 52);
            this.tbSensorId.Name = "tbSensorId";
            this.tbSensorId.Size = new System.Drawing.Size(100, 20);
            this.tbSensorId.TabIndex = 8;
            this.tbSensorId.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sensor ID:";
            // 
            // btnReadSensor
            // 
            this.btnReadSensor.Location = new System.Drawing.Point(8, 120);
            this.btnReadSensor.Name = "btnReadSensor";
            this.btnReadSensor.Size = new System.Drawing.Size(120, 47);
            this.btnReadSensor.TabIndex = 4;
            this.btnReadSensor.Text = "Read Sensor";
            this.btnReadSensor.UseVisualStyleBackColor = true;
            this.btnReadSensor.Click += new System.EventHandler(this.btnReadSensor_Click);
            // 
            // LdrReadClock
            // 
            this.LdrReadClock.Enabled = true;
            this.LdrReadClock.Interval = 1000;
            this.LdrReadClock.Tick += new System.EventHandler(this.LdrReadClock_Tick);
            // 
            // cbSwitchState
            // 
            this.cbSwitchState.FormattingEnabled = true;
            this.cbSwitchState.Location = new System.Drawing.Point(13, 145);
            this.cbSwitchState.Name = "cbSwitchState";
            this.cbSwitchState.Size = new System.Drawing.Size(121, 21);
            this.cbSwitchState.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbWriteSensorState);
            this.Controls.Add(this.gbStopTrain);
            this.Controls.Add(this.gbSwitchTrack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSwitchTrack.ResumeLayout(false);
            this.gbSwitchTrack.PerformLayout();
            this.gbStopTrain.ResumeLayout(false);
            this.gbStopTrain.PerformLayout();
            this.gbWriteSensorState.ResumeLayout(false);
            this.gbWriteSensorState.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSwitchTrack;
        private System.Windows.Forms.Button btnStopTrain;
        private System.Windows.Forms.Button btnWriteActuator;
        private System.Windows.Forms.GroupBox gbSwitchTrack;
        private System.Windows.Forms.GroupBox gbStopTrain;
        private System.Windows.Forms.GroupBox gbWriteSensorState;
        private System.Windows.Forms.Label lblSwitchState;
        private System.Windows.Forms.Label lblSwitchID;
        private System.Windows.Forms.TextBox tbSwitchID;
        private System.Windows.Forms.Label lblTrainID2;
        private System.Windows.Forms.TextBox tbTrainID2;
        private System.Windows.Forms.TextBox tbActuatorId;
        private System.Windows.Forms.Label lblSensor;
        private System.Windows.Forms.Label lblState2;
        private System.Windows.Forms.Button btnStartTrain;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSensorId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadSensor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSensorValue;
        private System.Windows.Forms.TextBox tbReadTimeLdr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDanger;
        internal System.Windows.Forms.Timer LdrReadClock;
        private System.Windows.Forms.ComboBox cbSwitchState;
    }
}

