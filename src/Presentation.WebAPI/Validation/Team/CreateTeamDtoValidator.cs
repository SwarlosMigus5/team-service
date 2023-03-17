// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateTeamDtoValidator.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CreateTeamDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Validation.Team
{
    using FluentValidation;
    using TeamService.Presentation.WebAPI.Dto.Input;

    /// <summary>
    /// <see cref="CreateTeamDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{CreateTeamDto}"/>
    public class CreateTeamDtoValidator : AbstractValidator<CreateTeamDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamDtoValidator"/> class.
        /// </summary>
        public CreateTeamDtoValidator()
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