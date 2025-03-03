﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace EF.Model
{
    public partial class Artikl
    {
        public Artikl()
        {
            Stavka = new HashSet<Stavka>();
        }

        /// <summary>
        /// Šifra artikla
        /// </summary>
        public int SifArtikla { get; set; }
        /// <summary>
        /// Naziv artikla
        /// </summary>
        public string NazArtikla { get; set; }
        /// <summary>
        /// Jedinica mjere
        /// </summary>
        public string JedMjere { get; set; }
        /// <summary>
        /// Cijena artikla
        /// </summary>
        public decimal CijArtikla { get; set; }
        /// <summary>
        /// Check box, usluge nemaju sliku
        /// </summary>
        public bool ZastUsluga { get; set; }
        public string TekstArtikla { get; set; }
        public byte[] SlikaArtikla { get; set; }
        public int? SlikaChecksum { get; set; }

        public virtual ICollection<Stavka> Stavka { get; set; }
    }
}