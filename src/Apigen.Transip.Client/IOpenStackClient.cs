using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Transip.Models;

#nullable enable

namespace Apigen.Transip.Client;

/// <summary>
/// Interface for OpenStack operations
/// </summary>
public interface IOpenStackClient
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
  Task CreateANewProjectAsync(Apigen.Transip.Models.CreateANewProjectRequest createANewProjectRequest);

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
  Task HandoverAProjectAsync(string projectId, Apigen.Transip.Models.HandoverAProjectRequest handoverAProjectRequest);

  /// <summary>
  /// Update a project
  /// Operation: PUT /openstack/projects/{projectId}
  /// </summary>
  Task UpdateAsync(string projectId, Apigen.Transip.Models.UpdateAProjectRequest updateAProjectRequest);

  /// <summary>
  /// List users that can be assigned to a project
  /// Operation: GET /openstack/projects/{projectId}/assignable-users
  /// </summary>
  Task<JsonElement> ListUsersThatCanBeAssignedToAProjectAsync(string projectId);

  /// <summary>
  /// List a single project quota
  /// Operation: GET /openstack/projects/{projectId}/quota
  /// </summary>
  Task<JsonElement> ListASingleProjectQuotaAsync(string projectId);

  /// <summary>
  /// Create an Objectstore quota
  /// Operation: POST /openstack/projects/{projectId}/quota
  /// </summary>
  Task CreateAnObjectstoreQuotaAsync(string projectId, Apigen.Transip.Models.CreateAnObjectstoreQuotaRequest createAnObjectstoreQuotaRequest);

  /// <summary>
  /// List users in a project
  /// Operation: GET /openstack/projects/{projectId}/users
  /// </summary>
  Task<JsonElement> ListUsersInAProjectAsync(string projectId);

  /// <summary>
  /// Add a user to a project
  /// Operation: POST /openstack/projects/{projectId}/users
  /// </summary>
  Task AddAUserToAProjectAsync(string projectId, Apigen.Transip.Models.AddAUserToAProjectRequest addAUserToAProjectRequest);

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
  Task CreateANewUserAsync(Apigen.Transip.Models.CreateANewUserRequest createANewUserRequest);

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
  Task ChangePasswordForAUserAsync(string userId, Apigen.Transip.Models.ChangePasswordForAUserRequest changePasswordForAUserRequest);

  /// <summary>
  /// Update a user
  /// Operation: PUT /openstack/users/{userId}
  /// </summary>
  Task UpdateAsync(string userId, Apigen.Transip.Models.UpdateAUserRequest updateAUserRequest);

  /// <summary>
  /// List all S3 tokens for a user
  /// Operation: GET /openstack/users/{userId}/tokens
  /// </summary>
  Task<JsonElement> ListAllS3TokensForAUserAsync(string userId);

  /// <summary>
  /// Create a new S3 token
  /// Operation: POST /openstack/users/{userId}/tokens
  /// </summary>
  Task<JsonElement> CreateANewS3TokenAsync(string userId, Apigen.Transip.Models.CreateANewS3TokenRequest createANewS3TokenRequest);

  /// <summary>
  /// Delete a S3 token
  /// Operation: DELETE /openstack/users/{userId}/tokens/{tokenId}
  /// </summary>
  Task DeleteAsync(string userId, string tokenId, Apigen.Transip.Models.DeleteAS3TokenRequest deleteAS3TokenRequest);

  /// <summary>
  /// List a S3 token
  /// Operation: GET /openstack/users/{userId}/tokens/{tokenId}
  /// </summary>
  Task<JsonElement> GetAsync(string userId, string tokenId);

}
