using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetkundigeFiguren
{
    class Cirkel
    {
        // Private variables with default values
        private int _straal = 10;
        private Point _middelpunt = new Point(100, 100);
        private Form _form;
        private int _lijnDikte = 1;
        private Color _kleur = Color.Black;

        // Default constructor and overloads
        public Cirkel() {
            // dit is de basisconstructor van de klasse
        }
        public Cirkel(int Straal) {
            _straal = Straal;
        }
        public Cirkel(Form frm, int Straal, Point Middelpunt, int LijnDikte, Color kleur) {
            _form = frm;
            _straal = Straal;
            _middelpunt = Middelpunt;
            _lijnDikte = LijnDikte;
            _kleur = kleur;
        }

        // getters/setters
        public int Straal
        {
            get { return _straal; }
            //set { _straal = value; }
        }
        public Point Middelpunt { get => _middelpunt; set => _middelpunt = value; }

        // methods
        public double Oppervlak() {
            return Math.PI * _straal * _straal;
        }
        public double Omtrek() {
            return 2 * Math.PI * _straal;
        }
        public void Teken() {
            // maak pen en papier-objecten aan
            Pen potlood = new Pen(_kleur, _lijnDikte);
            Graphics papier = _form.CreateGraphics();

            // teken de figuur op het papier
            papier.DrawEllipse(potlood, _middelpunt.X, _middelpunt.Y, _straal, _straal);
            
        }
    }
}
