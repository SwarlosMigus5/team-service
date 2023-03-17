// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateTeamDtoValidator.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// UpdateTeamDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Validation.Team
{
    using FluentValidation;
    using TeamService.Presentation.WebAPI.Dto.Input;

    /// <summary>
    /// <see cref="UpdateTeamDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{UpdateTeamDto}"/>
    public class UpdateTeamDtoValidator : AbstractValidator<UpdateTeamDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTeamDtoValidator"/> class.
        /// </summary>
        public UpdateTeamDtoValidator()
        {
            this.RuleFor(x => x.Name)
                .NotEmpty()
                    .WithMessage("The Name shouldn't be empty.");

            this.RuleFor(x => x.ShortName)
                .NotEmpty()
                    .WithMessage("The Short Name shouldn't be empty.");
        }
    }
}