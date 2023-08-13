using System;

using R5T.T0141;


namespace R5T.S0099
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        public void AdjustSolutionName_ForPrivacy()
        {
            /// Inputs.
            var solutionName = Instances.Values.Sample_SolutionName;
            var isPrivate = true;


            /// Run.
            var privacyAdjustedSolutionName = Instances.SolutionNameOperator.AdjustRepositoryName_ForPrivacy(
                solutionName,
                isPrivate);

            Console.WriteLine(
                $"{privacyAdjustedSolutionName}: privacy adjusted solution name\n\t{solutionName}: repository name\n\t{isPrivate}: is-private");
        }
    }
}
