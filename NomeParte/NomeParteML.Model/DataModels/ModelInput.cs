//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace NomeParteML.Model.DataModels
{
    public class ModelInput
    {
        [ColumnName("Masculino"), LoadColumn(0)]
        public bool Masculino { get; set; }


        [ColumnName("PrimeiroNomeNoAccents"), LoadColumn(1)]
        public string PrimeiroNomeNoAccents { get; set; }


    }
}
