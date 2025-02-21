﻿namespace CarBook.Application.Features.CQRS.Commands.CarCommands;

public class UpdateCarCommand
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    public string Model { get; set; }
    public string CoverImageUrl { get; set; }
    public int Km { get; set; }
    public string Transmission { get; set; }
    public byte Seat { get; set; }
    public byte Luggage { get; set; }
    public string Fuel { get; set; }
    public string BigImageUrl { get; set; }
}
