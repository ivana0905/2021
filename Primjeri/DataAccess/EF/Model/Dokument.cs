﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace EF.Model
{
    public partial class Dokument
    {
        public Dokument()
        {
            InverseIdPrethDokumentaNavigation = new HashSet<Dokument>();
            Stavka = new HashSet<Stavka>();
        }

        /// <summary>
        /// Identifikator dokumenta
        /// </summary>
        public int IdDokumenta { get; set; }
        /// <summary>
        /// Vrsta dokumenta
        /// </summary>
        public string VrDokumenta { get; set; }
        /// <summary>
        /// Broj dokumenta
        /// </summary>
        public int BrDokumenta { get; set; }
        /// <summary>
        /// Datum dokumenta
        /// </summary>
        public DateTime DatDokumenta { get; set; }
        /// <summary>
        /// Partner
        /// </summary>
        public int IdPartnera { get; set; }
        /// <summary>
        /// Prethodni dokument
        /// </summary>
        public int? IdPrethDokumenta { get; set; }
        /// <summary>
        /// Postotak poreza
        /// </summary>
        public decimal PostoPorez { get; set; }
        /// <summary>
        /// Ukupno stavke s porezom
        /// </summary>
        public decimal IznosDokumenta { get; set; }

        public virtual Partner IdPartneraNavigation { get; set; }
        public virtual Dokument IdPrethDokumentaNavigation { get; set; }
        public virtual ICollection<Dokument> InverseIdPrethDokumentaNavigation { get; set; }
        public virtual ICollection<Stavka> Stavka { get; set; }
    }
}