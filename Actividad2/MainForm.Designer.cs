/*
 * Created by SharpDevelop.
 * User: Edson
 * Date: 26/01/2020
 * Time: 02:44 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Actividad2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox gbProcess;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label lblMaxTime;
		private System.Windows.Forms.TextBox txtOperation;
		private System.Windows.Forms.Label lblOperation;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label lblNumberProcess;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.NumericUpDown nudMaxTime;
		private System.Windows.Forms.Button btnEjecutar;
		private System.Windows.Forms.GroupBox gbShow;
		private System.Windows.Forms.DataGridView dgvExecute;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Operación;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn TT;
		private System.Windows.Forms.DataGridViewTextBoxColumn TR;
		private System.Windows.Forms.Label lblInformation1;
		private System.Windows.Forms.Label lblInformation2;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.DataGridView dgvFinished;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.gbProcess = new System.Windows.Forms.GroupBox();
			this.btnEjecutar = new System.Windows.Forms.Button();
			this.lblNumberProcess = new System.Windows.Forms.Label();
			this.btnInsert = new System.Windows.Forms.Button();
			this.nudMaxTime = new System.Windows.Forms.NumericUpDown();
			this.lblMaxTime = new System.Windows.Forms.Label();
			this.txtOperation = new System.Windows.Forms.TextBox();
			this.lblOperation = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.lblId = new System.Windows.Forms.Label();
			this.gbShow = new System.Windows.Forms.GroupBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.lblCount = new System.Windows.Forms.Label();
			this.dgvFinished = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblInformation2 = new System.Windows.Forms.Label();
			this.lblInformation1 = new System.Windows.Forms.Label();
			this.dgvExecute = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Operación = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbProcess.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxTime)).BeginInit();
			this.gbShow.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFinished)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvExecute)).BeginInit();
			this.SuspendLayout();
			// 
			// gbProcess
			// 
			this.gbProcess.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.gbProcess.Controls.Add(this.btnEjecutar);
			this.gbProcess.Controls.Add(this.lblNumberProcess);
			this.gbProcess.Controls.Add(this.btnInsert);
			this.gbProcess.Controls.Add(this.nudMaxTime);
			this.gbProcess.Controls.Add(this.lblMaxTime);
			this.gbProcess.Controls.Add(this.txtOperation);
			this.gbProcess.Controls.Add(this.lblOperation);
			this.gbProcess.Controls.Add(this.txtName);
			this.gbProcess.Controls.Add(this.lblName);
			this.gbProcess.Controls.Add(this.txtId);
			this.gbProcess.Controls.Add(this.lblId);
			this.gbProcess.Location = new System.Drawing.Point(9, 10);
			this.gbProcess.Margin = new System.Windows.Forms.Padding(2);
			this.gbProcess.Name = "gbProcess";
			this.gbProcess.Padding = new System.Windows.Forms.Padding(2);
			this.gbProcess.Size = new System.Drawing.Size(708, 132);
			this.gbProcess.TabIndex = 0;
			this.gbProcess.TabStop = false;
			this.gbProcess.Text = "Captura";
			// 
			// btnEjecutar
			// 
			this.btnEjecutar.Location = new System.Drawing.Point(610, 79);
			this.btnEjecutar.Margin = new System.Windows.Forms.Padding(2);
			this.btnEjecutar.Name = "btnEjecutar";
			this.btnEjecutar.Size = new System.Drawing.Size(86, 39);
			this.btnEjecutar.TabIndex = 12;
			this.btnEjecutar.Text = "Inicio";
			this.btnEjecutar.UseVisualStyleBackColor = true;
			this.btnEjecutar.Click += new System.EventHandler(this.BtnEjecutarClick);
			// 
			// lblNumberProcess
			// 
			this.lblNumberProcess.AutoSize = true;
			this.lblNumberProcess.Location = new System.Drawing.Point(5, 92);
			this.lblNumberProcess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNumberProcess.Name = "lblNumberProcess";
			this.lblNumberProcess.Size = new System.Drawing.Size(0, 13);
			this.lblNumberProcess.TabIndex = 11;
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(512, 79);
			this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(86, 39);
			this.btnInsert.TabIndex = 10;
			this.btnInsert.Text = "Agregar";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.BtnInsertClick);
			// 
			// nudMaxTime
			// 
			this.nudMaxTime.Location = new System.Drawing.Point(198, 51);
			this.nudMaxTime.Margin = new System.Windows.Forms.Padding(2);
			this.nudMaxTime.Maximum = new decimal(new int[] {
			1000,
			0,
			0,
			0});
			this.nudMaxTime.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.nudMaxTime.Name = "nudMaxTime";
			this.nudMaxTime.Size = new System.Drawing.Size(90, 20);
			this.nudMaxTime.TabIndex = 9;
			this.nudMaxTime.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// lblMaxTime
			// 
			this.lblMaxTime.AutoSize = true;
			this.lblMaxTime.Location = new System.Drawing.Point(51, 52);
			this.lblMaxTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMaxTime.Name = "lblMaxTime";
			this.lblMaxTime.Size = new System.Drawing.Size(144, 13);
			this.lblMaxTime.TabIndex = 8;
			this.lblMaxTime.Text = "Tiempo máximo de ejecución";
			// 
			// txtOperation
			// 
			this.txtOperation.Location = new System.Drawing.Point(472, 17);
			this.txtOperation.Margin = new System.Windows.Forms.Padding(2);
			this.txtOperation.Name = "txtOperation";
			this.txtOperation.Size = new System.Drawing.Size(126, 20);
			this.txtOperation.TabIndex = 5;
			// 
			// lblOperation
			// 
			this.lblOperation.AutoSize = true;
			this.lblOperation.Location = new System.Drawing.Point(412, 20);
			this.lblOperation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblOperation.Name = "lblOperation";
			this.lblOperation.Size = new System.Drawing.Size(56, 13);
			this.lblOperation.TabIndex = 4;
			this.lblOperation.Text = "Operación";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(97, 17);
			this.txtName.Margin = new System.Windows.Forms.Padding(2);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(132, 20);
			this.txtName.TabIndex = 3;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(49, 20);
			this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(44, 13);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "Nombre";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(264, 17);
			this.txtId.Margin = new System.Windows.Forms.Padding(2);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(126, 20);
			this.txtId.TabIndex = 1;
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(245, 20);
			this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(16, 13);
			this.lblId.TabIndex = 0;
			this.lblId.Text = "Id";
			// 
			// gbShow
			// 
			this.gbShow.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.gbShow.Controls.Add(this.listBox1);
			this.gbShow.Controls.Add(this.lblCount);
			this.gbShow.Controls.Add(this.dgvFinished);
			this.gbShow.Controls.Add(this.lblInformation2);
			this.gbShow.Controls.Add(this.lblInformation1);
			this.gbShow.Controls.Add(this.dgvExecute);
			this.gbShow.Enabled = false;
			this.gbShow.Location = new System.Drawing.Point(9, 146);
			this.gbShow.Margin = new System.Windows.Forms.Padding(2);
			this.gbShow.Name = "gbShow";
			this.gbShow.Padding = new System.Windows.Forms.Padding(2);
			this.gbShow.Size = new System.Drawing.Size(829, 470);
			this.gbShow.TabIndex = 1;
			this.gbShow.TabStop = false;
			this.gbShow.Text = "Lotes";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(16, 70);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(213, 134);
			this.listBox1.TabIndex = 6;
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new System.Drawing.Point(295, 33);
			this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(53, 13);
			this.lblCount.TabIndex = 5;
			this.lblCount.Text = "Contador:";
			// 
			// dgvFinished
			// 
			this.dgvFinished.AllowUserToDeleteRows = false;
			this.dgvFinished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFinished.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.dataGridViewTextBoxColumn3,
			this.dataGridViewTextBoxColumn4,
			this.dataGridViewTextBoxColumn5,
			this.dataGridViewTextBoxColumn6,
			this.dataGridViewTextBoxColumn8,
			this.Lote});
			this.dgvFinished.Location = new System.Drawing.Point(5, 215);
			this.dgvFinished.Margin = new System.Windows.Forms.Padding(2);
			this.dgvFinished.Name = "dgvFinished";
			this.dgvFinished.ReadOnly = true;
			this.dgvFinished.RowTemplate.Height = 24;
			this.dgvFinished.Size = new System.Drawing.Size(805, 228);
			this.dgvFinished.TabIndex = 4;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Id";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Operación";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "Tiempo máximo";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.HeaderText = "Resultado";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// Lote
			// 
			this.Lote.HeaderText = "Lote";
			this.Lote.Name = "Lote";
			this.Lote.ReadOnly = true;
			// 
			// lblInformation2
			// 
			this.lblInformation2.AutoSize = true;
			this.lblInformation2.Location = new System.Drawing.Point(5, 43);
			this.lblInformation2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblInformation2.Name = "lblInformation2";
			this.lblInformation2.Size = new System.Drawing.Size(0, 13);
			this.lblInformation2.TabIndex = 3;
			// 
			// lblInformation1
			// 
			this.lblInformation1.AutoSize = true;
			this.lblInformation1.Location = new System.Drawing.Point(5, 18);
			this.lblInformation1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblInformation1.Name = "lblInformation1";
			this.lblInformation1.Size = new System.Drawing.Size(0, 13);
			this.lblInformation1.TabIndex = 2;
			// 
			// dgvExecute
			// 
			this.dgvExecute.AllowUserToDeleteRows = false;
			this.dgvExecute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvExecute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.dataGridViewTextBoxColumn1,
			this.Id,
			this.Operación,
			this.dataGridViewTextBoxColumn2,
			this.TT,
			this.TR});
			this.dgvExecute.Location = new System.Drawing.Point(244, 69);
			this.dgvExecute.Margin = new System.Windows.Forms.Padding(2);
			this.dgvExecute.Name = "dgvExecute";
			this.dgvExecute.ReadOnly = true;
			this.dgvExecute.RowTemplate.Height = 24;
			this.dgvExecute.Size = new System.Drawing.Size(566, 135);
			this.dgvExecute.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			// 
			// Operación
			// 
			this.Operación.HeaderText = "Operación";
			this.Operación.Name = "Operación";
			this.Operación.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Tiempo máximo";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// TT
			// 
			this.TT.HeaderText = "Tiempo transcurrido";
			this.TT.Name = "TT";
			this.TT.ReadOnly = true;
			// 
			// TR
			// 
			this.TR.HeaderText = "Tiempo restante";
			this.TR.Name = "TR";
			this.TR.ReadOnly = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSlateGray;
			this.ClientSize = new System.Drawing.Size(844, 610);
			this.Controls.Add(this.gbShow);
			this.Controls.Add(this.gbProcess);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "Actividad 2 - Procesamiento por lotes";
			this.gbProcess.ResumeLayout(false);
			this.gbProcess.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxTime)).EndInit();
			this.gbShow.ResumeLayout(false);
			this.gbShow.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFinished)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvExecute)).EndInit();
			this.ResumeLayout(false);

		}

        private System.Windows.Forms.ListBox listBox1;
    }
}
