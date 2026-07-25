public ProductService(IUnitOfWork unitOfwork, IMapper mapper)

public async Task<Result<IReadOnLyList<BrandDto>>> GetALlBrandsAsync(CancellationToken ct = default)
public async Task<Result<PaginatedResult<Productto>>> GetAlLProductsAsync(ProductQueryParams
queryParams, CancellationToken ct = default)
{
var Spec = new ProductWithBrandAndTypeSpec(queryParams);
var products = await _unitOfwork.GetRepository<Product, int>().GetAllAsync(Spec, ct);
var data = _mapper.Map<IReadOnLyList<ProductDto>>(products);
var countSpec = new ProductCountSpecification(queryParams);
var CountOfAllProducs= await unitOfWork.GetRepository<Product, int>().CountAsync(countSpec);
var result = new PaginatedResult<Productto>(queryParams.PageIndex, queryParams.PageSize, CountOfALLProducs, data);
return Result<PaginatedResult<ProductDto>>.Ok(result);
}
public async Task<Result<IReadOnLyList<TypeDto>>> GetAllTypesAsync(CancellationToken ct = default)

public async Task<Result<ProductDto»> GetProductByIdAsync(int id, CancellationToken ct = default)
