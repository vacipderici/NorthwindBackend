﻿using Business.Abstract;
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
            throw new NotImplementedException();
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
