// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateTeamAcronymDtoValidator.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CreateTeamAcronymDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Validation.Team
{
    using FluentValidation;
    using TeamService.Presentation.WebAPI.Dto.Input;

    /// <summary>
    /// <see cref="CreateTeamAcronymDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{CreateTeamAcronymDto}"/>
    public class CreateTeamAcronymDtoValidator : AbstractValidator<CreateTeamAcronymDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamAcronymDtoValidator"/> class.
        /// </summary>
        public CreateTeamAcronymDtoValidator()
        {
            this.RuleFor(x => x.Acronym)
                .NotEmpty()
                    .WithMessage("The Acronym shouldn't be empty.")
                .MaximumLength(20)
                    .WithMessage("The Acronym shouldn't be longer than 20 characters.");
        }
    }
}