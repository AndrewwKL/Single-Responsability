using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ArdalisRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        public decimal Rating { get; set; }
        public void Rate()
        {
           Print.TextoInicial();
            LoadPolicy Load_Policy = new LoadPolicy();
            Auto vehiculo = new Auto();
            Land land = new Land();
            Life life = new Life();
            var policy=Load_Policy.loadPolicy();
            switch (policy.Type)
            {
                case PolicyType.Auto:
                    vehiculo.showAuto(policy, Rating);
                    break;

                case PolicyType.Land:
                    land.showLand(policy, Rating);
                    break;

                case PolicyType.Life:
                   life.showLife(policy, Rating);
                    break;

                default:
                    Print.Default();
                    break;
            }
                    Print.FinalText();
        }
    }
}
