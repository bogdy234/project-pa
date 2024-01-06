using System.Windows.Forms;

namespace PA_Proiect
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPretProdus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.txtNumeProdus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addProductButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clientEmailTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clientNameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addClientButton = new System.Windows.Forms.Button();
            this.deleteClient = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtPretProdus);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.deleteProduct);
            this.tabPage1.Controls.Add(this.txtNumeProdus);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.addProductButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Produs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtPretProdus
            // 
            this.txtPretProdus.Location = new System.Drawing.Point(663, 189);
            this.txtPretProdus.Name = "txtPretProdus";
            this.txtPretProdus.Size = new System.Drawing.Size(100, 20);
            this.txtPretProdus.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pret Produs";
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(18, 347);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(110, 23);
            this.deleteProduct.TabIndex = 4;
            this.deleteProduct.Text = "Sterge produs";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // txtNumeProdus
            // 
            this.txtNumeProdus.Location = new System.Drawing.Point(663, 129);
            this.txtNumeProdus.Name = "txtNumeProdus";
            this.txtNumeProdus.Size = new System.Drawing.Size(100, 20);
            this.txtNumeProdus.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume Produs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(6, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 300);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(663, 239);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(100, 23);
            this.addProductButton.TabIndex = 0;
            this.addProductButton.Text = "Adauga Produs";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clientEmailTb);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.clientNameTb);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.addClientButton);
            this.tabPage2.Controls.Add(this.deleteClient);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clientEmailTb
            // 
            this.clientEmailTb.Location = new System.Drawing.Point(670, 206);
            this.clientEmailTb.Name = "clientEmailTb";
            this.clientEmailTb.Size = new System.Drawing.Size(100, 20);
            this.clientEmailTb.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email client";
            // 
            // clientNameTb
            // 
            this.clientNameTb.Location = new System.Drawing.Point(670, 146);
            this.clientNameTb.Name = "clientNameTb";
            this.clientNameTb.Size = new System.Drawing.Size(100, 20);
            this.clientNameTb.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nume client";
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(670, 250);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(100, 23);
            this.addClientButton.TabIndex = 7;
            this.addClientButton.Text = "Adauga Client";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // deleteClient
            // 
            this.deleteClient.Location = new System.Drawing.Point(19, 310);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(110, 23);
            this.deleteClient.TabIndex = 5;
            this.deleteClient.Text = "Sterge client";
            this.deleteClient.UseVisualStyleBackColor = true;
            this.deleteClient.Click += new System.EventHandler(this.deleteClient_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView2.Location = new System.Drawing.Point(19, 17);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(612, 256);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellValueChanged += dataGridView2_CellValueChanged;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtPretProdus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.TextBox txtNumeProdus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addProductButton;
        private DataGridView dataGridView2;
        private Button deleteClient;
        private TextBox clientEmailTb;
        private Label label3;
        private TextBox clientNameTb;
        private Label label4;
        private Button addClientButton;
    }
}