namespace VS_OrdenamientoBurbuja {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn15objetosAleatorios = new System.Windows.Forms.Button();
            this.btnGenerar5Aleatorios = new System.Windows.Forms.Button();
            this.btnGenerar15Aleatorio = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSenialIzquierda = new System.Windows.Forms.Button();
            this.btnSenialDerecha = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radDirectto = new System.Windows.Forms.RadioButton();
            this.radPasoAPaso = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn15objetosAleatorios);
            this.groupBox1.Controls.Add(this.btnGenerar5Aleatorios);
            this.groupBox1.Controls.Add(this.btnGenerar15Aleatorio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar";
            // 
            // btn15objetosAleatorios
            // 
            this.btn15objetosAleatorios.BackColor = System.Drawing.Color.Azure;
            this.btn15objetosAleatorios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn15objetosAleatorios.Location = new System.Drawing.Point(6, 77);
            this.btn15objetosAleatorios.Name = "btn15objetosAleatorios";
            this.btn15objetosAleatorios.Size = new System.Drawing.Size(157, 25);
            this.btn15objetosAleatorios.TabIndex = 2;
            this.btn15objetosAleatorios.Text = "50 objetos aleatorios";
            this.btn15objetosAleatorios.UseVisualStyleBackColor = false;
            this.btn15objetosAleatorios.Click += new System.EventHandler(this.btn15objetosAleatorios_Click);
            // 
            // btnGenerar5Aleatorios
            // 
            this.btnGenerar5Aleatorios.BackColor = System.Drawing.Color.Azure;
            this.btnGenerar5Aleatorios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar5Aleatorios.Location = new System.Drawing.Point(6, 49);
            this.btnGenerar5Aleatorios.Name = "btnGenerar5Aleatorios";
            this.btnGenerar5Aleatorios.Size = new System.Drawing.Size(157, 25);
            this.btnGenerar5Aleatorios.TabIndex = 1;
            this.btnGenerar5Aleatorios.Text = "5 numeros 5-1";
            this.btnGenerar5Aleatorios.UseVisualStyleBackColor = false;
            this.btnGenerar5Aleatorios.Click += new System.EventHandler(this.btnGenerar5Aleatorios_Click);
            // 
            // btnGenerar15Aleatorio
            // 
            this.btnGenerar15Aleatorio.BackColor = System.Drawing.Color.Azure;
            this.btnGenerar15Aleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar15Aleatorio.Location = new System.Drawing.Point(6, 21);
            this.btnGenerar15Aleatorio.Name = "btnGenerar15Aleatorio";
            this.btnGenerar15Aleatorio.Size = new System.Drawing.Size(157, 25);
            this.btnGenerar15Aleatorio.TabIndex = 0;
            this.btnGenerar15Aleatorio.Text = "15 numeros aleatorios";
            this.btnGenerar15Aleatorio.UseVisualStyleBackColor = false;
            this.btnGenerar15Aleatorio.Click += new System.EventHandler(this.btnGenerar15Aleatorio_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(389, 26);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(100, 330);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSenialIzquierda);
            this.groupBox2.Controls.Add(this.btnSenialDerecha);
            this.groupBox2.Controls.Add(this.btnDerecha);
            this.groupBox2.Controls.Add(this.btnIzquierda);
            this.groupBox2.Location = new System.Drawing.Point(308, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 108);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de ordenamiento";
            // 
            // btnSenialIzquierda
            // 
            this.btnSenialIzquierda.BackColor = System.Drawing.Color.Azure;
            this.btnSenialIzquierda.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSenialIzquierda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSenialIzquierda.Location = new System.Drawing.Point(301, 21);
            this.btnSenialIzquierda.Name = "btnSenialIzquierda";
            this.btnSenialIzquierda.Size = new System.Drawing.Size(132, 81);
            this.btnSenialIzquierda.TabIndex = 3;
            this.btnSenialIzquierda.Text = "Izquierda con señal ascendentemente";
            this.btnSenialIzquierda.UseVisualStyleBackColor = false;
            this.btnSenialIzquierda.Click += new System.EventHandler(this.btnSenialIzquierda_Click);
            // 
            // btnSenialDerecha
            // 
            this.btnSenialDerecha.BackColor = System.Drawing.Color.Azure;
            this.btnSenialDerecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSenialDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSenialDerecha.Location = new System.Drawing.Point(446, 21);
            this.btnSenialDerecha.Name = "btnSenialDerecha";
            this.btnSenialDerecha.Size = new System.Drawing.Size(132, 81);
            this.btnSenialDerecha.TabIndex = 2;
            this.btnSenialDerecha.Text = "Derecha con señal ascendentemente";
            this.btnSenialDerecha.UseVisualStyleBackColor = false;
            this.btnSenialDerecha.Click += new System.EventHandler(this.btnSenialDerecha_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.BackColor = System.Drawing.Color.Azure;
            this.btnDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDerecha.Location = new System.Drawing.Point(157, 21);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(131, 81);
            this.btnDerecha.TabIndex = 1;
            this.btnDerecha.Text = "Derecha ascendentemente";
            this.btnDerecha.UseVisualStyleBackColor = false;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.BackColor = System.Drawing.Color.Azure;
            this.btnIzquierda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzquierda.Location = new System.Drawing.Point(12, 21);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(132, 81);
            this.btnIzquierda.TabIndex = 0;
            this.btnIzquierda.Text = "Izquierda ascendentemente";
            this.btnIzquierda.UseVisualStyleBackColor = false;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Izquierda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Derecha";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radDirectto);
            this.groupBox3.Controls.Add(this.radPasoAPaso);
            this.groupBox3.Location = new System.Drawing.Point(187, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(115, 108);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preferencias";
            // 
            // radDirectto
            // 
            this.radDirectto.AutoSize = true;
            this.radDirectto.Checked = true;
            this.radDirectto.Location = new System.Drawing.Point(6, 29);
            this.radDirectto.Name = "radDirectto";
            this.radDirectto.Size = new System.Drawing.Size(93, 17);
            this.radDirectto.TabIndex = 1;
            this.radDirectto.TabStop = true;
            this.radDirectto.Text = "Directamente";
            this.radDirectto.UseVisualStyleBackColor = true;
            // 
            // radPasoAPaso
            // 
            this.radPasoAPaso.AutoSize = true;
            this.radPasoAPaso.Location = new System.Drawing.Point(6, 69);
            this.radPasoAPaso.Name = "radPasoAPaso";
            this.radPasoAPaso.Size = new System.Drawing.Size(88, 17);
            this.radPasoAPaso.TabIndex = 0;
            this.radPasoAPaso.Text = "Paso a paso";
            this.radPasoAPaso.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 126);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(886, 405);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(878, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Numeros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(878, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Objetos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Izquierda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Derecha";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(66, 6);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(806, 366);
            this.dataGridView2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 533);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ordenamiento burbuja";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerar15Aleatorio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radDirectto;
        private System.Windows.Forms.RadioButton radPasoAPaso;
        private System.Windows.Forms.Button btnGenerar5Aleatorios;
        private System.Windows.Forms.Button btnSenialDerecha;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnSenialIzquierda;
        private System.Windows.Forms.Button btn15objetosAleatorios;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

