namespace Pizza_Delivery
{
    partial class Form2
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
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label telefonLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonAnuleaza = new System.Windows.Forms.Button();
            this.clientiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clientiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStrada = new System.Windows.Forms.TextBox();
            this.textBoxNumar = new System.Windows.Forms.TextBox();
            this.textBoxValoare = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBon = new System.Windows.Forms.TextBox();
            this.buttonBon = new System.Windows.Forms.Button();
            this.buttonCalculeaza = new System.Windows.Forms.Button();
            numeLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingNavigator)).BeginInit();
            this.clientiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.BackColor = System.Drawing.Color.Gray;
            numeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            numeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            numeLabel.ForeColor = System.Drawing.Color.SeaShell;
            numeLabel.Location = new System.Drawing.Point(52, 127);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(69, 22);
            numeLabel.TabIndex = 7;
            numeLabel.Text = "Nume:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.BackColor = System.Drawing.Color.Gray;
            telefonLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            telefonLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            telefonLabel.ForeColor = System.Drawing.Color.SeaShell;
            telefonLabel.Location = new System.Drawing.Point(52, 162);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(80, 22);
            telefonLabel.TabIndex = 9;
            telefonLabel.Text = "Telefon:";
            // 
            // buttonAnuleaza
            // 
            this.buttonAnuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnuleaza.Location = new System.Drawing.Point(426, 471);
            this.buttonAnuleaza.Name = "buttonAnuleaza";
            this.buttonAnuleaza.Size = new System.Drawing.Size(122, 35);
            this.buttonAnuleaza.TabIndex = 3;
            this.buttonAnuleaza.Text = "Anuleaza";
            this.buttonAnuleaza.UseVisualStyleBackColor = true;
            this.buttonAnuleaza.Click += new System.EventHandler(this.buttonAnuleaza_Click_1);
            // 
            // clientiBindingNavigator
            // 
            this.clientiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientiBindingNavigator.BindingSource = this.clientiBindingSource;
            this.clientiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.clientiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clientiBindingNavigatorSaveItem});
            this.clientiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientiBindingNavigator.Name = "clientiBindingNavigator";
            this.clientiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientiBindingNavigator.Size = new System.Drawing.Size(1302, 27);
            this.clientiBindingNavigator.TabIndex = 5;
            this.clientiBindingNavigator.Text = "bindingNavigator1";
            this.clientiBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // clientiBindingNavigatorSaveItem
            // 
            this.clientiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientiBindingNavigatorSaveItem.Image")));
            this.clientiBindingNavigatorSaveItem.Name = "clientiBindingNavigatorSaveItem";
            this.clientiBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.clientiBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // textBoxNume
            // 
            this.textBoxNume.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "Nume", true));
            this.textBoxNume.Location = new System.Drawing.Point(152, 129);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(272, 22);
            this.textBoxNume.TabIndex = 8;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "Telefon", true));
            this.textBoxTelefon.Location = new System.Drawing.Point(152, 164);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(272, 22);
            this.textBoxTelefon.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(51, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Introduceti datele de livrare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(52, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Modalitatea de plata:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.comboBox1.Location = new System.Drawing.Point(280, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(52, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Strada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(292, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Numarul:";
            // 
            // textBoxStrada
            // 
            this.textBoxStrada.Location = new System.Drawing.Point(161, 290);
            this.textBoxStrada.Name = "textBoxStrada";
            this.textBoxStrada.Size = new System.Drawing.Size(100, 22);
            this.textBoxStrada.TabIndex = 16;
            // 
            // textBoxNumar
            // 
            this.textBoxNumar.Location = new System.Drawing.Point(410, 290);
            this.textBoxNumar.Name = "textBoxNumar";
            this.textBoxNumar.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumar.TabIndex = 17;
            // 
            // textBoxValoare
            // 
            this.textBoxValoare.Location = new System.Drawing.Point(296, 380);
            this.textBoxValoare.Name = "textBoxValoare";
            this.textBoxValoare.ReadOnly = true;
            this.textBoxValoare.Size = new System.Drawing.Size(141, 22);
            this.textBoxValoare.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.SeaShell;
            this.label6.Location = new System.Drawing.Point(471, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "RON";
            // 
            // textBoxBon
            // 
            this.textBoxBon.Location = new System.Drawing.Point(651, 91);
            this.textBoxBon.Multiline = true;
            this.textBoxBon.Name = "textBoxBon";
            this.textBoxBon.Size = new System.Drawing.Size(183, 347);
            this.textBoxBon.TabIndex = 22;
            // 
            // buttonBon
            // 
            this.buttonBon.Location = new System.Drawing.Point(681, 475);
            this.buttonBon.Name = "buttonBon";
            this.buttonBon.Size = new System.Drawing.Size(123, 26);
            this.buttonBon.TabIndex = 23;
            this.buttonBon.Text = "Afiseaza Bon";
            this.buttonBon.UseVisualStyleBackColor = true;
            this.buttonBon.Click += new System.EventHandler(this.buttonBon_Click);
            // 
            // buttonCalculeaza
            // 
            this.buttonCalculeaza.BackColor = System.Drawing.Color.Gray;
            this.buttonCalculeaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculeaza.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCalculeaza.Location = new System.Drawing.Point(55, 362);
            this.buttonCalculeaza.Name = "buttonCalculeaza";
            this.buttonCalculeaza.Size = new System.Drawing.Size(206, 59);
            this.buttonCalculeaza.TabIndex = 24;
            this.buttonCalculeaza.Text = "Calculeaza Valoarea Comenzii:";
            this.buttonCalculeaza.UseVisualStyleBackColor = false;
            this.buttonCalculeaza.Click += new System.EventHandler(this.buttonCalculeaza_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Delivery.Properties.Resources.dd81e151eee6e6abf3ed648624ec2e0d;
            this.ClientSize = new System.Drawing.Size(1302, 544);
            this.Controls.Add(this.buttonCalculeaza);
            this.Controls.Add(this.buttonBon);
            this.Controls.Add(this.textBoxBon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxValoare);
            this.Controls.Add(this.textBoxNumar);
            this.Controls.Add(this.textBoxStrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.clientiBindingNavigator);
            this.Controls.Add(this.buttonAnuleaza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizare Comanda";
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingNavigator)).EndInit();
            this.clientiBindingNavigator.ResumeLayout(false);
            this.clientiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAnuleaza;
       // private DataSet dataSet;
        private System.Windows.Forms.BindingSource clientiBindingSource;
      //  private DataSetTableAdapters.ClientiTableAdapter clientiTableAdapter;
     //   private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clientiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStrada;
        private System.Windows.Forms.TextBox textBoxNumar;
        private System.Windows.Forms.TextBox textBoxValoare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBon;
        private System.Windows.Forms.Button buttonBon;
        private System.Windows.Forms.Button buttonCalculeaza;
    }
}