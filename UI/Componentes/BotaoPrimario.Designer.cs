namespace UI.Componentes
{
    partial class BotaoPrimario
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            Anchor = AnchorStyles.Right;
            BackColor = Color.FromArgb(100, 111, 229);
            Cursor = Cursors.Hand;
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = Color.FromArgb(5, 6, 63);
            Location = new Point(553, 3);
            Size = new Size(116, 34);
            TabIndex = 1;
            Text = "Texto";
            UseVisualStyleBackColor = false;
        }

        #endregion
    }
}
