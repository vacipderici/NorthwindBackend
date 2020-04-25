using Business.Abstract;
using Business.Constans;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Jwt;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
        public AuthManager(IUserService userService,ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;

        }
        public AuthManager()
        {

        }
        public IDataResult<AccessToken> CreateAccessTOken(User user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck ==null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }
            //Kulanıcının gnderdiği şifreyi tuzlayıp hasleri kontrol edeceğiz db ile. Hashlema için hashelper yapacağız.
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            throw new NotImplementedException();
        }

        public IResult UserExist(string mail)
        {
            throw new NotImplementedException();
        }
    }
}
