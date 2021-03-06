﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;
using SoccerLeagueTransferApp.Models.ConData;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using SoccerLeagueTransferApp.Data;

namespace SoccerLeagueTransferApp.Pages
{
    public partial class AddUsersComponent
    {
        [Inject]

        AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        public async Task CheckUserStatus()//it checks if anonymous user has signed in
        {
            try
            {
                var userState = await ((CustomAuthenticationStateProvider)AuthenticationStateProvider).GetAuthenticationStateAsync();

                if (userState.User.Claims.Any() && userState.User.IsInRole("SiteAdmin"))// check if user has any claims and see if user belongs to site admin role
                {
                    //do nothing

                }
                else
                {
                    UriHelper.NavigateTo("login");//redirect to login page
                }
            }
            catch(Exception ex)
            {
                NotificationService.Notify(NotificationSeverity.Error, "Application Error", "An Error Has Occurred.Please Contact Site Admin", 5000);
            }
           
        }

        //custom custom to add a new application user and associated role list

        private async Task MuyikAddNewUser()
        {
            //check if user has been assigned to any role
            if(userRoleNames.Any())
            {
                List<UsersInRole> usersInRoles = new List<UsersInRole>();//create new userInroles list
                foreach(string roleName in userRoleNames)//iterate over all rolenames
                {
                    Role role = await ConData.MuyikGetRoleByName(roleName);//check if a role which matches current role exists in datastore
                    if(role!=null && role.RoleID > 0)
                    {
                        usersInRoles.Add(new UsersInRole { RoleID = role.RoleID, User = user });//create new user in role object and add it to userInRoles list
                    }
                }

                user.UsersInRoles = usersInRoles; //attach user in roles list to current user object

                //add new user to datastore
                var result = await ConData.CreateUser(user);
                if(result.UserID > 0)//checking if new user was successfully created
                {
                    UriHelper.NavigateTo("users", true);
                }
                else//user not created
                {
                    NotificationService.Notify(NotificationSeverity.Error, "User Creation Error", "An error occurred while creating new user", 5000);
                    return;
                }
            }
            //else user not assigned to any role
            else
            {
                NotificationService.Notify(NotificationSeverity.Error, "No Role Assignment", "You Have Not Assigned This User To Any Role", 5000);
                return;
            }
        }
    }
}
