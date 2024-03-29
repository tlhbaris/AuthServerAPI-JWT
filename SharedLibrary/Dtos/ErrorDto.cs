﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
    public class ErrorDto
    {
        public List<String> Errors { get; private set; }
        public bool IsShow { get; private set; }

        public ErrorDto()
        {
            Errors = new List<String>();
        }
        public ErrorDto(string error,bool isShow)
        {
            Errors.Add(error);
            isShow = true;

        }
        public ErrorDto(List<string> errors, bool isShow)
        {
            Errors = Errors;
            IsShow = isShow;
        }
    }
}
