/*
 * Creado por SharpDevelop.
 * Usuario: Ing. Omar
 * Fecha: 28/04/2014
 * Hora: 16:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practica_4_Examen
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			
			
						
						
						int cont = 0;
						
      					
						
						
			if(this.checkBox1.Checked & this.checkBox4.Checked){
				cont = cont + 1; 
			}

			  if(this.radioButton2.Checked){
				cont= cont + 1;
			}
			
			if(this.numericUpDown1.Text == "31"){
				cont = cont + 1;
			}
			
			if(this.monthCalendar1.SelectionStart.Date.ToShortDateString() == "16/09/1810"){
				cont= cont + 1;
				
			}
			
			 System.Windows.Forms.MessageBox.Show("Respuestas Correctas son "+ cont    ); 
		}
		
		
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void NumericUpDown1ValueChanged(object sender, EventArgs e)
		{
			
		}
	}
		
		
}
