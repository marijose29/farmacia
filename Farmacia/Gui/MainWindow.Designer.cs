namespace Farmacia
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_Actividad = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_SearchTextBox = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_Actividad);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 574);
            this.panel1.TabIndex = 0;
            // 
            // m_Actividad
            // 
            this.m_Actividad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_Actividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_Actividad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.m_Actividad.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Actividad.FormattingEnabled = true;
            this.m_Actividad.IntegralHeight = false;
            this.m_Actividad.ItemHeight = 32;
            this.m_Actividad.Location = new System.Drawing.Point(0, 47);
            this.m_Actividad.Margin = new System.Windows.Forms.Padding(4);
            this.m_Actividad.Name = "m_Actividad";
            this.m_Actividad.Size = new System.Drawing.Size(188, 527);
            this.m_Actividad.TabIndex = 1;
            this.m_Actividad.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.m_Actividad_DrawItem);
            this.m_Actividad.DoubleClick += new System.EventHandler(this.m_Actividad_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_SearchTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(188, 47);
            this.panel2.TabIndex = 0;
            // 
            // m_SearchTextBox
            // 
            this.m_SearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_SearchTextBox.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_SearchTextBox.Location = new System.Drawing.Point(10, 10);
            this.m_SearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_SearchTextBox.Name = "m_SearchTextBox";
            this.m_SearchTextBox.Size = new System.Drawing.Size(168, 26);
            this.m_SearchTextBox.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(188, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 574);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 574);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Farmacia";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox m_SearchTextBox;
        private System.Windows.Forms.ListBox m_Actividad;
    }
}

