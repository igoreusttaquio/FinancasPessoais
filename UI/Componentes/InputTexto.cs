﻿using System.ComponentModel;

namespace UI.Componentes
{
    public partial class InputTexto : UserControl
    {
        public InputTexto()
        {
            InitializeComponent();
        }

        [Browsable(true)]  // Propriedade visível no PropertyGrid
        [Category("Customizados")]
        [Description("Texto que será exibido no input.")]
        public string Texto
        {
            get => Input.Text;
            set
            {
                if (Input.Text != value)
                {
                    Input.Text = value;
                }
            }
        }

        [Browsable(true)]  // Propriedade visível no PropertyGrid
        [Category("Customizados")]
        [Description("Label que será exibido no input.")]
        public string Label
        {
            get => Titulo.Text;
            set => Titulo.Text = value;
        }

    }
}
