using FluentValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentValidation.Validator
{
    public class ValidatorFactory : ValidatorFactoryBase
    {
        private static Dictionary<Type, IValidator> validators = new Dictionary<Type, IValidator>();

        public ValidatorFactory()
        {
            validators.Add(typeof(IValidator<UserModel>), new UserModelViewValidator());
        }

        public override IValidator CreateInstance(Type validatorType)
        {
            IValidator validator;
            if (validators.TryGetValue(validatorType, out validator))
                return validator;
            return validator;
        }
    }
}