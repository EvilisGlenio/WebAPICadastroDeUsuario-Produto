﻿using WebAPI.Entities;

namespace WebAPI.Repository
{
    public interface InterfaceProduct
    {
        Task Add(ProductModel Objeto);
        Task Update(ProductModel Objeto);
        Task Delete(ProductModel Objeto);
        Task<ProductModel> GetEntityById(int Id);
        Task<List<ProductModel>> List();
    }
}
