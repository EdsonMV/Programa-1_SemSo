/*
 * Created by SharpDevelop.
 * User: Edson
 * Date: 26/01/2020
 * Time: 02:56 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */


using System;

namespace Actividad2
{
	/// <summary>
	/// Description of Batch.
	/// </summary>
	public class Batch
	{
		private Process [] field_batch = new Process[5];
		private int field_count;
		
		public Batch() { field_count = 0; }
		
		public int count {
			get { return field_count; }
			}
		
		public void insertProcess(Process p) {
			field_batch[field_count] = p;
			field_count++;
			}
		
		public Boolean isBatchEmpty() {
			if (field_count == 0) { return true; }
			return false;
			}
		
		public Boolean isBatchFull() {
			if (field_count == 5) return true;
			return false;
			}
		
		public Boolean isIdEqual(int id) {
			if (isBatchEmpty() == false) {
				for (int i = 0; i < field_count; i++) {
					if (field_batch[i].id == id) return true;
					}
				}
			return false;
			}
		
		public Process getProcess(int pos) {
			return field_batch[pos];
			}
		}
	}
