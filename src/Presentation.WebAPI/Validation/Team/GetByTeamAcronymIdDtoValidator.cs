// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetByTeamAcronymIdDtoValidator.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetByTeamAcronymIdDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Validation.Team
{
    using FluentValidation;
    using TeamService.Presentation.WebAPI.Dto.Input;

    /// <summary>
    /// <see cref="GetByTeamAcronymIdDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{GetByTeamAcronymIdDto}"/>
    public class GetByTeamAcronymIdDtoValidator : AbstractValidator<GetByTeamAcronymIdDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetByTeamAcronymIdDtoValidator"/> class.
        /// </summary>
        public GetByTeamAcronymIdDtoValidator()
        {
            this.RuleFor(x => x.TeamAcronymId)
                .NotEqual(Guid.Empty)
                    .WithMessage("The Team Acronym Id shouldn't be empty.");
        }
    }
}