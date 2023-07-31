SELECT Product.Name as 'Продукт', Category.Name as 'Категория'
from Product left join Category on Product.id_category = Category.id_category
