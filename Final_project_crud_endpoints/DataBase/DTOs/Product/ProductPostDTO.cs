using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Final_project_crud_endpoints.Validations;
using Microsoft.AspNetCore.Http;

public class ProductPostDTO
{
    [Display(Name = "Name")]
    [Required(ErrorMessage = "Product name is required!")]
    [RegularExpression(pattern: @"^[a-zA-Z0-9\s\""'\-+\*,()]*$", ErrorMessage = "The product name contains invalid characters. Please use only letters, numbers, and the following special characters: ")]
    [StringLength(50, MinimumLength = 5, ErrorMessage = "Product name must be between 5 and 50 characters!")]
    public string Name { get; set; } = string.Empty;
    [Display(Name = "Description")]  
    [Required(ErrorMessage = "Product description is required!")]
    [RegularExpression(pattern: @"^[a-zA-Z0-9\s\""'\-+\*,()]*$", ErrorMessage = "The entered product description must consist of only uppercase, lowercase letters, numbers and special characters!")]
    [StringLength(360, MinimumLength = 60, ErrorMessage = "Product description must be between 60 and 360 characters!")]
    public string Description { get; set; } = string.Empty;
    [Display(Name = "Price")]
    [Required(ErrorMessage = "Product price is required.")]
    [Range(25, double.MaxValue, ErrorMessage = "Price must be greater than 25.")]
    [DataType(DataType.Currency, ErrorMessage = "Invalid currency format.")]
    public decimal Price { get; set; }
    [Display(Name = "Files")]
    [Required(ErrorMessage = "At least one file must be selected.")]
    [MaxFileSize(5 * 1024 * 1024, ErrorMessage = "Each file must be no larger than 5MB.")]
    [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png", ".gif" }, ErrorMessage = "Only image files are supported.")]
    public IFormFileCollection Files { get; set; }
    [Display(Name= "Quantity")]
    [Required(ErrorMessage = "Product quantity is required.")]
    [Range(5, int.MaxValue, ErrorMessage = "Quantity must be at least 5.")]
    public int Quantity { get; set; }
    [Display(Name = "Discount")]
    [Range(0, 100, ErrorMessage = "Discount must be between 0 and 100.")]
    public int Discount { get; set; }
    [Display(Name= "Manufacturing date")]
    [Required(ErrorMessage = "Manufacturing date is required.")]
    [DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime ManufacturedAt { get; set; }

    [Display(Name = "Current deepcategory ID")]
    [Required(ErrorMessage = "Valid deepcategory ID is required.")]
    [FixedLength(36, ErrorMessage = "The field must be exactly 36 characters long!")]
    [RegularExpression(@"^(?:\{{0,1}(?:[0-9a-fA-F]){8}-(?:[0-9a-fA-F]){4}-(?:[0-9a-fA-F]){4}-(?:[0-9a-fA-F]){4}-(?:[0-9a-fA-F]){12}\}{0,1})$",
    ErrorMessage = "The field must be a valid GUID.")]
    public Guid Current_Deepcategory_Id { get; set; }
    [Display(Name = "Current brand ID")]
    [Required(ErrorMessage = "Valid brand ID is required.")]
    [FixedLength(36, ErrorMessage = "The field must be exactly 36 characters long!")]
    [RegularExpression(@"^(?:\{{0,1}(?:[0-9a-fA-F]){8}-(?:[0-9a-fA-F]){4}-(?:[0-9a-fA-F]){4}-(?:[0-9a-fA-F]){4}-(?:[0-9a-fA-F]){12}\}{0,1})$",
    ErrorMessage = "The field must be a valid GUID.")]
    public Guid Current_Brand_Id { get; set; }
    [Display(Name = "Color IDs")]
    [Required(ErrorMessage = "Valid Color IDs is required.")]
    public Guid[] ColorIds { get; set; }
    [Display(Name = "Size IDs")]
    [Required(ErrorMessage = "Valid Size IDs is required.")]
    public Guid[] SizeIds { get; set; }
    [Display(Name = "Warranty IDs")]
    [Required(ErrorMessage = "Valid Warranty IDs is required.")]
    public Guid[] WarrantyIds { get; set; }
    [Display(Name = "Store IDs")]
    [Required(ErrorMessage = "Valid Store IDs is required.")]
    public Guid[] StoreIds { get; set; }
}



