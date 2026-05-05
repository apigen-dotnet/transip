using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Transip.Models;

#nullable enable

namespace Apigen.Transip.Client;

/// <summary>
/// Interface for Kubernetes operations
/// </summary>
public interface IKubernetesClient
{
  /// <summary>
  /// List all clusters
  /// Operation: GET /kubernetes/clusters
  /// </summary>
  Task<JsonElement> ListAllClustersAsync();

  /// <summary>
  /// Create new cluster
  /// Operation: POST /kubernetes/clusters
  /// </summary>
  Task CreateNewClusterAsync(Apigen.Transip.Models.CreateNewClusterRequest createNewClusterRequest);

  /// <summary>
  /// Remove cluster
  /// Operation: DELETE /kubernetes/clusters/{clusterName}
  /// </summary>
  Task DeleteAsync(string clusterName);

  /// <summary>
  /// List single cluster
  /// Operation: GET /kubernetes/clusters/{clusterName}
  /// </summary>
  Task<JsonElement> GetAsync(string clusterName);

  /// <summary>
  /// Block mail ports
  /// Operation: PATCH /kubernetes/clusters/{clusterName}
  /// </summary>
  Task BlockMailPortsAsync(string clusterName, Apigen.Transip.Models.BlockMailPortsRequest blockMailPortsRequest);

  /// <summary>
  /// Update cluster
  /// Operation: PUT /kubernetes/clusters/{clusterName}
  /// </summary>
  Task UpdateAsync(string clusterName, Apigen.Transip.Models.UpdateClusterRequest updateClusterRequest);

  /// <summary>
  /// List all volumes
  /// Operation: GET /kubernetes/clusters/{clusterName}/block-storages
  /// </summary>
  Task<JsonElement> ListAllVolumesAsync(string clusterName);

  /// <summary>
  /// Remove volume
  /// Operation: DELETE /kubernetes/clusters/{clusterName}/block-storages/{name}
  /// </summary>
  Task DeleteAsync(string clusterName, string name);

  /// <summary>
  /// List single volume
  /// Operation: GET /kubernetes/clusters/{clusterName}/block-storages/{name}
  /// </summary>
  Task<JsonElement> GetAsync(string name, string clusterName, Apigen.Transip.Models.ListSingleVolumeRequest listSingleVolumeRequest);

  /// <summary>
  /// Update volume
  /// Operation: PUT /kubernetes/clusters/{clusterName}/block-storages/{name}
  /// </summary>
  Task UpdateAsync(string clusterName, string name, Apigen.Transip.Models.UpdateVolumeRequest updateVolumeRequest);

  /// <summary>
  /// Get block storage statistics
  /// Operation: GET /kubernetes/clusters/{clusterName}/block-storages/{name}/stats
  /// </summary>
  Task<JsonElement> GetBlockStorageStatisticsAsync(string clusterName, string name, Apigen.Transip.Models.GetBlockStorageStatisticsRequest getBlockStorageStatisticsRequest);

  /// <summary>
  /// List all events
  /// Operation: GET /kubernetes/clusters/{clusterName}/events
  /// </summary>
  Task<JsonElement> ListAllEventsAsync(string clusterName);

  /// <summary>
  /// List an event
  /// Operation: GET /kubernetes/clusters/{clusterName}/events/{name}
  /// </summary>
  Task<JsonElement> GetAsync(string clusterName, string name);

  /// <summary>
  /// Get KubeConfig for Cluster
  /// Operation: GET /kubernetes/clusters/{clusterName}/kube-config
  /// </summary>
  Task<JsonElement> GetKubeConfigForClusterAsync(string clusterName);

  /// <summary>
  /// List all LoadBalancers
  /// Operation: GET /kubernetes/clusters/{clusterName}/load-balancers
  /// </summary>
  Task<JsonElement> ListAllLoadBalancersAsync(string clusterName);

  /// <summary>
  /// Add a LoadBalancer
  /// Operation: POST /kubernetes/clusters/{clusterName}/load-balancers
  /// </summary>
  Task AddALoadBalancerAsync(string clusterName, Apigen.Transip.Models.AddALoadBalancerRequest addALoadBalancerRequest);

  /// <summary>
  /// Remove a LoadBalancer
  /// Operation: DELETE /kubernetes/clusters/{clusterName}/load-balancers/{name}
  /// </summary>
  Task DeleteKubernetesClustersLoadBalancersAsync(string clusterName, string name);

  /// <summary>
  /// Get LoadBalancer info
  /// Operation: GET /kubernetes/clusters/{clusterName}/load-balancers/{name}
  /// </summary>
  Task<JsonElement> GetKubernetesClustersLoadBalancersAsync(string clusterName, string name);

  /// <summary>
  /// Update a loadBalancer
  /// Operation: PUT /kubernetes/clusters/{clusterName}/load-balancers/{name}
  /// </summary>
  Task UpdateAsync(string clusterName, string name, Apigen.Transip.Models.UpdateALoadBalancerRequest updateALoadBalancerRequest);

  /// <summary>
  /// List all LoadBalancer status reports
  /// Operation: GET /kubernetes/clusters/{clusterName}/load-balancers/{name}/status-reports
  /// </summary>
  Task<JsonElement> ListAllLoadBalancerStatusReportsAsync(string clusterName, string name);

  /// <summary>
  /// Get LoadBalancer info
  /// Operation: GET /kubernetes/clusters/{clusterName}/load-balancers/{name}/status-reports/{nodeUuid}
  /// </summary>
  Task<JsonElement> GetAsync(string clusterName, string name, string nodeUuid);

  /// <summary>
  /// List all nodepools
  /// Operation: GET /kubernetes/clusters/{clusterName}/node-pools
  /// </summary>
  Task<JsonElement> ListAllNodepoolsAsync(string clusterName);

  /// <summary>
  /// Add nodepool
  /// Operation: POST /kubernetes/clusters/{clusterName}/node-pools
  /// </summary>
  Task<JsonElement> AddNodepoolAsync(string clusterName, Apigen.Transip.Models.AddNodepoolRequest addNodepoolRequest);

  /// <summary>
  /// Remove nodepool
  /// Operation: DELETE /kubernetes/clusters/{clusterName}/node-pools/{uuid}
  /// </summary>
  Task DeleteKubernetesClustersNodePoolsAsync(string clusterName, string uuid);

  /// <summary>
  /// List single nodepool
  /// Operation: GET /kubernetes/clusters/{clusterName}/node-pools/{uuid}
  /// </summary>
  Task<JsonElement> GetKubernetesClustersNodePoolsAsync(string clusterName, string uuid);

  /// <summary>
  /// Update nodepool
  /// Operation: PUT /kubernetes/clusters/{clusterName}/node-pools/{uuid}
  /// </summary>
  Task UpdateAsync(string clusterName, string uuid, Apigen.Transip.Models.UpdateNodepoolRequest updateNodepoolRequest);

  /// <summary>
  /// List all labels
  /// Operation: GET /kubernetes/clusters/{clusterName}/node-pools/{uuid}/labels
  /// </summary>
  Task<JsonElement> ListAllLabelsAsync(string clusterName, string uuid);

  /// <summary>
  /// Update labels
  /// Operation: PUT /kubernetes/clusters/{clusterName}/node-pools/{uuid}/labels
  /// </summary>
  Task UpdateLabelsAsync(string clusterName, string uuid, Apigen.Transip.Models.UpdateLabelsRequest updateLabelsRequest);

  /// <summary>
  /// List all taints
  /// Operation: GET /kubernetes/clusters/{clusterName}/node-pools/{uuid}/taints
  /// </summary>
  Task<JsonElement> ListAllTaintsAsync(string clusterName, string uuid);

  /// <summary>
  /// Update taints
  /// Operation: PUT /kubernetes/clusters/{clusterName}/node-pools/{uuid}/taints
  /// </summary>
  Task UpdateTaintsAsync(string clusterName, string uuid, Apigen.Transip.Models.UpdateTaintsRequest updateTaintsRequest);

  /// <summary>
  /// List all nodes
  /// Operation: GET /kubernetes/clusters/{clusterName}/nodes
  /// </summary>
  Task<JsonElement> ListAllNodesAsync(string clusterName, Apigen.Transip.Models.ListAllNodesRequest listAllNodesRequest);

  /// <summary>
  /// List single node
  /// Operation: GET /kubernetes/clusters/{clusterName}/nodes/{uuid}
  /// </summary>
  Task<JsonElement> GetKubernetesClustersNodesAsync(string clusterName, string uuid);

  /// <summary>
  /// Reboot a node
  /// Operation: PATCH /kubernetes/clusters/{clusterName}/nodes/{uuid}
  /// </summary>
  Task RebootANodeAsync(string clusterName, string uuid, Apigen.Transip.Models.RebootANodeRequest rebootANodeRequest);

  /// <summary>
  /// Get node statistics
  /// Operation: GET /kubernetes/clusters/{clusterName}/nodes/{uuid}/stats
  /// </summary>
  Task<JsonElement> GetNodeStatisticsAsync(string clusterName, string uuid, Apigen.Transip.Models.GetNodeStatisticsRequest getNodeStatisticsRequest);

  /// <summary>
  /// List all available Kubernetes releases
  /// Operation: GET /kubernetes/clusters/{clusterName}/releases
  /// </summary>
  Task<JsonElement> ListAllAvailableKubernetesReleasesAsync(string clusterName);

  /// <summary>
  /// List a single Kubernetes release
  /// Operation: GET /kubernetes/clusters/{clusterName}/releases/{version}
  /// </summary>
  Task<JsonElement> GetKubernetesClustersReleasesAsync(string clusterName, string version);

  /// <summary>
  /// List kubernetes products
  /// Operation: GET /kubernetes/products
  /// </summary>
  Task<JsonElement> ListKubernetesProductsAsync();

  /// <summary>
  /// Get information about a Kubernetes product
  /// Operation: GET /kubernetes/products/{product}
  /// </summary>
  Task<JsonElement> GetKubernetesProductsAsync(string product);

  /// <summary>
  /// List all available Kubernetes releases
  /// Operation: GET /kubernetes/releases
  /// </summary>
  Task<JsonElement> ListAllAvailableKubernetesReleasesAsync();

  /// <summary>
  /// List a single Kubernetes release
  /// Operation: GET /kubernetes/releases/{version}
  /// </summary>
  Task<JsonElement> GetKubernetesReleasesAsync(string version);

}
