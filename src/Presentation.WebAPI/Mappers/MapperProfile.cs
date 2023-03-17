// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapperProfile.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// MapperProfile
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Mappers
{
    using AutoMapper;
    using TeamService.Domain.AggregateModels.Team;
    using TeamService.Presentation.WebAPI.Dto.Output;

    /// <summary>
    /// <see cref="MapperProfile"/>
    /// </summary>
    /// <seealso cref="Profile"/>
    public class MapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapperProfile"/> class.
        /// </summary>
        public MapperProfile()
        {
            this.CreateMap<TeamAcronym, TeamAcronymDetailsDto>();
            this.CreateMap<Team, TeamDetailsDto>();
            this.CreateMap<Team, TeamDto>();
        }
    }
}