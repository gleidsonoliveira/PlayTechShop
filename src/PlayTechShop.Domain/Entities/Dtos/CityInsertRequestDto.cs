﻿namespace PlayTechShop.Domain.Entities.Dtos;
public class CityInsertRequestDto
{
    public string Name { get; set; }
    public string CodeCity { get; set; }
    public long StateId { get; set; }
    public bool IsValidated { get; set; }
}
