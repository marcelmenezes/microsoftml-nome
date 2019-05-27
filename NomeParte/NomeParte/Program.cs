using System;
using NomeParteML.Model.DataModels;
using Microsoft.ML;
using System.Collections.Generic;

namespace NomeParte
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumeModel();
        }

        public static void ConsumeModel()
        {
            // Load the model
            MLContext mlContext = new MLContext();

            ITransformer mlModel = mlContext.Model.Load("MLModel.zip", out var modelInputSchema);

            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);

            // Use the code below to add input data
            var input = new ModelInput();

            var nomes = new List<string>() {
                "JOÃO",
                "MARIA",
                "THIAGO",
                "NIKOLAS",
                "ANDERSON",
                "RAFAEL",
                "RAFAELA",
            };

            foreach(var nome in nomes)
            {

                input.PrimeiroNomeNoAccents = nome;
                var result = predEngine.Predict(input);
                Console.WriteLine($"Text: {input.PrimeiroNomeNoAccents} | Prediction Male: {result.Prediction} ");
            }

            Console.ReadLine();
        }
    }
}