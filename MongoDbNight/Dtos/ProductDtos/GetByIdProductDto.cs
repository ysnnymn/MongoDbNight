﻿namespace MongoDbNight.Dtos.ProductDtos
{
    public class GetByIdProductDto
    {

        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
