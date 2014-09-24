/*
 * Created by SharpDevelop.
 * User: matthias.obst
 * Date: 22.09.2014
 * Time: 12:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DbExport
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.btnStartImport = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtHost = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnOpenFileDialog = new System.Windows.Forms.Button();
			this.txtFolderPath = new System.Windows.Forms.TextBox();
			this.btnDbConnection = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.btnStartExport = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSaveFileDialog = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cBDatabases = new System.Windows.Forms.ComboBox();
			this.lBLog = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnStartImport
			// 
			this.btnStartImport.Location = new System.Drawing.Point(356, 237);
			this.btnStartImport.Name = "btnStartImport";
			this.btnStartImport.Size = new System.Drawing.Size(87, 23);
			this.btnStartImport.TabIndex = 0;
			this.btnStartImport.Text = "Import starten";
			this.btnStartImport.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Hostadresse";
			// 
			// txtHost
			// 
			this.txtHost.Location = new System.Drawing.Point(102, 19);
			this.txtHost.Name = "txtHost";
			this.txtHost.Size = new System.Drawing.Size(180, 20);
			this.txtHost.TabIndex = 2;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(102, 45);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(180, 20);
			this.txtUsername.TabIndex = 2;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(102, 71);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(180, 20);
			this.txtPassword.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Benutzername";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "Passwort";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 242);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Import XML-File";
			// 
			// btnOpenFileDialog
			// 
			this.btnOpenFileDialog.Location = new System.Drawing.Point(124, 234);
			this.btnOpenFileDialog.Name = "btnOpenFileDialog";
			this.btnOpenFileDialog.Size = new System.Drawing.Size(42, 29);
			this.btnOpenFileDialog.TabIndex = 4;
			this.btnOpenFileDialog.Text = "folder";
			this.btnOpenFileDialog.UseVisualStyleBackColor = true;
			// 
			// txtFolderPath
			// 
			this.txtFolderPath.Enabled = false;
			this.txtFolderPath.Location = new System.Drawing.Point(185, 239);
			this.txtFolderPath.Name = "txtFolderPath";
			this.txtFolderPath.Size = new System.Drawing.Size(142, 20);
			this.txtFolderPath.TabIndex = 5;
			// 
			// btnDbConnection
			// 
			this.btnDbConnection.Location = new System.Drawing.Point(12, 110);
			this.btnDbConnection.Name = "btnDbConnection";
			this.btnDbConnection.Size = new System.Drawing.Size(135, 23);
			this.btnDbConnection.TabIndex = 6;
			this.btnDbConnection.Text = "Zu Datenbank verbinden";
			this.btnDbConnection.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(164, 115);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(118, 18);
			this.label5.TabIndex = 7;
			this.label5.Text = "DatabaseConnection";
			// 
			// btnStartExport
			// 
			this.btnStartExport.Location = new System.Drawing.Point(356, 202);
			this.btnStartExport.Name = "btnStartExport";
			this.btnStartExport.Size = new System.Drawing.Size(87, 23);
			this.btnStartExport.TabIndex = 0;
			this.btnStartExport.Text = "Export starten";
			this.btnStartExport.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(13, 207);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 18);
			this.label6.TabIndex = 3;
			this.label6.Text = "Export Dateipfad";
			// 
			// btnSaveFileDialog
			// 
			this.btnSaveFileDialog.Location = new System.Drawing.Point(124, 199);
			this.btnSaveFileDialog.Name = "btnSaveFileDialog";
			this.btnSaveFileDialog.Size = new System.Drawing.Size(42, 29);
			this.btnSaveFileDialog.TabIndex = 4;
			this.btnSaveFileDialog.Text = "folder";
			this.btnSaveFileDialog.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(185, 204);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(142, 20);
			this.textBox1.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 162);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(135, 18);
			this.label7.TabIndex = 9;
			this.label7.Text = "Verfügbare Datenbanken";
			// 
			// cBDatabases
			// 
			this.cBDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cBDatabases.FormattingEnabled = true;
			this.cBDatabases.Location = new System.Drawing.Point(150, 159);
			this.cBDatabases.Name = "cBDatabases";
			this.cBDatabases.Size = new System.Drawing.Size(164, 21);
			this.cBDatabases.TabIndex = 10;
			// 
			// lBLog
			// 
			this.lBLog.FormattingEnabled = true;
			this.lBLog.Location = new System.Drawing.Point(12, 269);
			this.lBLog.Name = "lBLog";
			this.lBLog.Size = new System.Drawing.Size(499, 134);
			this.lBLog.TabIndex = 11;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 408);
			this.Controls.Add(this.lBLog);
			this.Controls.Add(this.cBDatabases);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnDbConnection);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.txtFolderPath);
			this.Controls.Add(this.btnSaveFileDialog);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnOpenFileDialog);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.txtHost);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnStartExport);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnStartImport);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(539, 446);
			this.MinimumSize = new System.Drawing.Size(539, 446);
			this.Name = "MainForm";
			this.Text = "DbExim";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ListBox lBLog;
		private System.Windows.Forms.ComboBox cBDatabases;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnSaveFileDialog;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnStartExport;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnDbConnection;
		private System.Windows.Forms.TextBox txtFolderPath;
		private System.Windows.Forms.Button btnOpenFileDialog;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtHost;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnStartImport;
	}
}
