using System.Text.Json;
using System.Threading.Tasks;
using Apigen.TransIp.Models;

#nullable enable

namespace Apigen.TransIp.Client;

/// <summary>
/// Interface for OpenStack operations
/// </summary>
public partial interface IOpenStackClient
{
  /// <summary>
  /// List all projects
  /// Operation: GET /openstack/projects
  /// </summary>
  Task<JsonElement> ListAllProjectsAsync();

  /// <summary>
  /// Create a new project
  /// Operation: POST /openstack/projects
  /// </summary>
  Task CreateNewProjectAsync(Apigen.TransIp.Models.CreateNewProjectRequest createNewProjectRequest);

  /// <summary>
  /// Cancel a Project
  /// Operation: DELETE /openstack/projects/{projectId}
  /// </summary>
  Task DeleteAsync(string projectId);

  /// <summary>
  /// List a single project
  /// Operation: GET /openstack/projects/{projectId}
  /// </summary>
  Task<JsonElement> GetAsync(string projectId);

  /// <summary>
  /// Handover a project
  /// Operation: PATCH /openstack/projects/{projectId}
  /// </summary>
  Task HandoverProjectAsync(string projectId, Apigen.TransIp.Models.HandoverProjectRequest handoverProjectRequest);

  /// <summary>
  /// Update a project
  /// Operation: PUT /openstack/projects/{projectId}
  /// </summary>
  Task UpdateAsync(string projectId, Apigen.TransIp.Models.UpdateProjectRequest updateProjectRequest);

  /// <summary>
  /// List users that can be assigned to a project
  /// Operation: GET /openstack/projects/{projectId}/assignable-users
  /// </summary>
  Task<JsonElement> ListUsersThatCanBeAssignedProjectAsync(string projectId);

  /// <summary>
  /// List a single project quota
  /// Operation: GET /openstack/projects/{projectId}/quota
  /// </summary>
  Task<JsonElement> ListSingleProjectQuotaAsync(string projectId);

  /// <summary>
  /// Create an Objectstore quota
  /// Operation: POST /openstack/projects/{projectId}/quota
  /// </summary>
  Task CreateObjectstoreQuotaAsync(string projectId, Apigen.TransIp.Models.CreateObjectstoreQuotaRequest createObjectstoreQuotaRequest);

  /// <summary>
  /// List users in a project
  /// Operation: GET /openstack/projects/{projectId}/users
  /// </summary>
  Task<JsonElement> ListUsersInProjectAsync(string projectId);

  /// <summary>
  /// Add a user to a project
  /// Operation: POST /openstack/projects/{projectId}/users
  /// </summary>
  Task AddUserProjectAsync(string projectId, Apigen.TransIp.Models.AddUserProjectRequest addUserProjectRequest);

  /// <summary>
  /// Remove a user from project
  /// Operation: DELETE /openstack/projects/{projectId}/users/{userId}
  /// </summary>
  Task DeleteAsync(string projectId, string userId);

  /// <summary>
  /// List all users
  /// Operation: GET /openstack/users
  /// </summary>
  Task<JsonElement> ListAllUsersAsync();

  /// <summary>
  /// Create a new user
  /// Operation: POST /openstack/users
  /// </summary>
  Task CreateNewUserAsync(Apigen.TransIp.Models.CreateNewUserRequest createNewUserRequest);

  /// <summary>
  /// Delete a user
  /// Operation: DELETE /openstack/users/{userId}
  /// </summary>
  Task DeleteOpenstackUsersAsync(string userId);

  /// <summary>
  /// List a user
  /// Operation: GET /openstack/users/{userId}
  /// </summary>
  Task<JsonElement> GetOpenstackUsersAsync(string userId);

  /// <summary>
  /// Change password for a user
  /// Operation: PATCH /openstack/users/{userId}
  /// </summary>
  Task ChangePasswordUserAsync(string userId, Apigen.TransIp.Models.ChangePasswordUserRequest changePasswordUserRequest);

  /// <summary>
  /// Update a user
  /// Operation: PUT /openstack/users/{userId}
  /// </summary>
  Task UpdateAsync(string userId, Apigen.TransIp.Models.UpdateUserRequest updateUserRequest);

  /// <summary>
  /// List all S3 tokens for a user
  /// Operation: GET /openstack/users/{userId}/tokens
  /// </summary>
  Task<JsonElement> ListAllS3TokensUserAsync(string userId);

  /// <summary>
  /// Create a new S3 token
  /// Operation: POST /openstack/users/{userId}/tokens
  /// </summary>
  Task<JsonElement> CreateNewS3TokenAsync(string userId, Apigen.TransIp.Models.CreateNewS3TokenRequest createNewS3TokenRequest);

  /// <summary>
  /// Delete a S3 token
  /// Operation: DELETE /openstack/users/{userId}/tokens/{tokenId}
  /// </summary>
  Task DeleteAsync(string userId, string tokenId, Apigen.TransIp.Models.DeleteS3TokenRequest deleteS3TokenRequest);

  /// <summary>
  /// List a S3 token
  /// Operation: GET /openstack/users/{userId}/tokens/{tokenId}
  /// </summary>
  Task<JsonElement> GetAsync(string userId, string tokenId);

}
