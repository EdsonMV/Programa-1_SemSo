/*
 * Created by SharpDevelop.
 * User: Edson
 * Date: 26/01/2020
 * Time: 02:44 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Actividad2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{		
		public MainForm() {
			InitializeComponent();
			lblNumberProcess.Text = "Procesos añadidos: " + Convert.ToString(processCount);
			}
		
		static Double eval(String expression) {
    		var table = new System.Data.DataTable();
    		return Convert.ToDouble(table.Compute(expression, String.Empty));
			}
		
		private List<Batch> listBatch = new List<Batch>();
		private int batchCount = 0;
		private int processCount = 0;
		
		void isInTheList(int id) {
			foreach (Batch b in listBatch) {
				if (b.isIdEqual(id)) {
					throw new Exception("Ese ID ya existe.");
					}
				}
			}	
		
		void clearAll() {
			txtId.Clear();
			txtName.Clear();
			txtOperation.Clear();
			nudMaxTime.Value = 1;
			}
		
		void BtnInsertClick(object sender, EventArgs e) {
			if (listBatch.Count == 0) {
				var newBatch = new Batch();
				listBatch.Add(newBatch);
				}
			
			if (listBatch[batchCount].isBatchFull()) {
				var newBatch = new Batch();
				listBatch.Add(newBatch);
				batchCount++;
				}
			
			try {
				var newProcess = new Process();
				isInTheList(Convert.ToInt16(txtId.Text));
				newProcess.id = Convert.ToInt16(txtId.Text);
				newProcess.name = txtName.Text;
				newProcess.operation = txtOperation.Text;
				newProcess.maxTime = Convert.ToInt16(nudMaxTime.Value);
				newProcess.result = eval(newProcess.operation);
				listBatch[batchCount].insertProcess(newProcess);
				lblNumberProcess.Text = "Procesos añadidos: " + Convert.ToString(++processCount);
				clearAll();
				} 
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
				}
			}	
		
		async void BtnEjecutarClick(object sender, EventArgs e) {
			
			gbProcess.Enabled = false;
			gbShow.Enabled = true;
			int count_global = 0;
			int processCount = 0;

            List<string> info = new List<string>();
            int cont;
            for(int i = 0 ; i < listBatch.Count; i++){
            	cont = 1;
            	info.Add("----LOTE " + ++cont +" ----");
            	
            	for(int j = 0; j < listBatch[i].count; j++){
            		info.Add(" Nombre: " + listBatch[i].getProcess(j).name + " - Tiempo maximo: " + listBatch[i].getProcess(j).maxTime);
            		listBox1.DataSource = null;
                	listBox1.DataSource = info;
      
            	}
            	int x =0;
            }
			
			lblCount.Text = "Contador: " + Convert.ToInt16(count_global);
			
			for (int i = 0; i < listBatch.Count; i++) {
                //info.Clear();
				lblInformation1.Text = "Lotes pendientes: " + Convert.ToString(listBatch.Count - (i + 1));
				lblInformation2.Text = "Lote actual: " + Convert.ToString(i + 1);
				
				if(info.Count > 0){
				info.RemoveAt(0);
				listBox1.DataSource = null;
                listBox1.DataSource = info;
				}
				
				for (int k = 0; k < listBatch[i].count; k++) {
					int intern_count = 0;
            
                 
					//info.Add(" Nombre: " + listBatch[i].getProcess(k).name + " - Tiempo maximo: " + listBatch[i].getProcess(k).maxTime);// Creacion de la cadena con nombre y maxtima
					//listBox1.DataSource = null;
                    //listBox1.DataSource = info;
                    
                    if(info.Count > 0){
						info.RemoveAt(0);
						listBox1.DataSource = null;
                    	listBox1.DataSource = info;						
					}
					
					Process p = listBatch[i].getProcess(k);
					

					for (int t = 1; t <= p.maxTime; t++) {
						dgvExecute.Rows[0].Cells[0].Value = p.name;
						dgvExecute.Rows[0].Cells[1].Value = p.id;
						dgvExecute.Rows[0].Cells[2].Value = p.operation;
						dgvExecute.Rows[0].Cells[3].Value = p.maxTime;
						dgvExecute.Rows[0].Cells[4].Value = t;
						dgvExecute.Rows[0].Cells[5].Value = p.maxTime - t;
						await Task.Delay(1000);
						lblCount.Text = "Contador: " + Convert.ToInt16(++count_global);
						}
					
					dgvFinished.Rows.Add(1);
					dgvFinished.Rows[processCount].Cells[0].Value = p.name;
					dgvFinished.Rows[processCount].Cells[1].Value = p.id;
					dgvFinished.Rows[processCount].Cells[2].Value = p.operation;
					dgvFinished.Rows[processCount].Cells[3].Value = p.maxTime;
					dgvFinished.Rows[processCount].Cells[4].Value = p.result;
					dgvFinished.Rows[processCount++].Cells[5].Value = i + 1;
					dgvExecute.Rows.Clear();
					}
				}
			}
		}	
	}
