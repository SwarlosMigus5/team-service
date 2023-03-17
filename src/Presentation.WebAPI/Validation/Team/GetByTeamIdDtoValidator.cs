// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetByTeamIdDtoValidator.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetByTeamIdDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Validation.Team
{
    using FluentValidation;
    using TeamService.Presentation.WebAPI.Dto.Input;

    /// <summary>
    /// <see cref="GetByTeamIdDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{GetByTeamIdDto}"/>
    public class GetByTeamIdDtoValidator : AbstractValidator<GetByTeamIdDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetByTeamIdDtoValidator"/> class.
        /// </summary>
        public GetByTeamIdDtoValidator()
        {
            this.RuleFor(x => x.TeamId)
                .NotEqual(Guid.Empty)
                    .WithMessage("The Team Id shouldn't be empty.");
        }
    }
}