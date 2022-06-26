using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.CategoryListed);
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId), Messages.CategoryListed);
        }


        [ValidationAspect(typeof(CategoryValidator))]
        public IResult Add(Category category)
        {
            IResult result = BusinessRules.Run(CheckIfCategoryNameExists(category.CategoryName));

            if (result !=null)
            {
                return result;
            }

            _categoryDal.Add(category);

            return new SuccessResult(Messages.CategoryAdded);
        }

        private IResult CheckIfCategoryNameExists(string categoryName)
        {
            var result = _categoryDal.GetAll(c => c.CategoryName == categoryName).Any();

            if (result)
            {
                return new ErrorResult(Messages.CategoryNameAlreadyExists);
            }

            return new SuccessResult(Messages.CategoryAdded);
        }
    }
}
