using RestEase;
using StrapiHeadless.Client.Commands;
using StrapiHeadless.Client.Models;

namespace StrapiHeadless.Client;

public interface IStrapiClient
{
    [Header("Authorization")] public string Authorization { get; set; }
    
    [Get("/products")]
    Task<IList<ProductEntity>> GetProducts();
    
    [Post("/products")]
    Task<StrapiDocument> CreateProduct([Body] CreateProductCommand request);
    
    [Post("/categories")]
    Task<StrapiDocument> CreateCategory([Body] CreateCategoryCommand request);
    
    [Get("/categories")]
    Task<IList<CategoryEntity>> GetCategories();
}