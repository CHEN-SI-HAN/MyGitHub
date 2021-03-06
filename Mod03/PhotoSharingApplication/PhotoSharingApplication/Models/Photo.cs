﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;



namespace PhotoSharingApplication.Models
{
    public class Photo
    {
        public int PhotoID { get; set; }
        [Required]
        public string Title {get;set;}
        [DisplayName("Picture")]
        [MaxLength]
        public byte[] PhotoFile { get;set;}
        [HiddenInput(DisplayValue = false)]
        public string ImageMimeType { get;set;}
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayName("Created Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        public string UserName { get; set; }

        
    }
}