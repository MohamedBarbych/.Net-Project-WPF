﻿using System.ComponentModel.DataAnnotations;

public class Categorie
{
    [Key]
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Description { get; set; }
}