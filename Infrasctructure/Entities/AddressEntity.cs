﻿using System.ComponentModel.DataAnnotations;

namespace Infrasctructure.Entities;

public class AddressEntity
{
    [Key]
    public int Id { get; set; }
    public string UserId { get; set; } = null!;
    public UserEntity User { get; set; } = null!;

    public string AddressLine_1 { get; set; } = null!;
    public string? AddressLine_2 { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;

}
