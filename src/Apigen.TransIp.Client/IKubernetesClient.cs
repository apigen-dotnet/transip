using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.TransIp.Models;

#nullable enable

namespace Apigen.TransIp.Client;

/// <summary>
/// Interface for Kubernetes operations
/// </summary>
public partial interface IKubernetesClient
{
  /// <summary>
  /// List all clusters
  /// Operation: GET /kubernetes/clusters
  /// </summary>
  Task<JsonElement> ListAllClustersAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Create new cluster
  /// Operation: POST /kubernetes/clusters
  /// </summary>
  Task CreateNewClusterAsync(Apigen.TransIp.Models.CreateNewClusterRequest createNewClusterRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Remove cluster
  /// Operation: DELETE /kubernetes/clusters/{clusterName}
  /// </summary>
  Task DeleteAsync(string clusterName, CancellationToken cancellationToken = default);

  /// <summary>
  /// List single cluster
  /// Operation: GET /kubernetes/clusters/{clusterName}
  /// </summary>
  Task<JsonElement> GetAsync(string clusterName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Block mail ports
  /// Operation: PATCH /kubernetes/clusters/{clusterName}
  /// </summary>
  Task BlockMailPortsAsync(string clusterName, Apigen.TransIp.Models.BlockMailPortsRequest blockMailPortsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update cluster
  /// Operation: PUT /kubernetes/clusters/{clusterName}
  /// </summary>
  Task UpdateAsync(string clusterName, Apigen.TransIp.Models.UpdateClusterRequest updateClusterRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all volumes
  /// Operation: GET /kubernetes/clusters/{clusterName}/block-storages
  /// </summary>
  Task<JsonElement> ListAllVolumesAsync(string clusterName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Remove volume
  /// Operation: DELETE /kubernetes/clusters/{clusterName}/block-storages/{name}
  /// </summary>
  Task DeleteAsync(string clusterName, string name, CancellationToken cancellationToken = default);

  /// <summary>
  /// List single volume
  /// Operation: GET /kubernetes/clusters/{clusterName}/block-storages/{name}
  /// </summary>
  Task<JsonElement> GetAsync(string name, string clusterName, Apigen.TransIp.Models.ListSingleVolumeRequest listSingleVolumeRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update volume
  /// Operation: PUT /kubernetes/clusters/{clusterName}/block-storages/{name}
  /// </summary>
  Task UpdateAsync(string clusterName, string name, Apigen.TransIp.Models.UpdateVolumeRequest updateVolumeRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get block storage statistics
  /// Operation: GET /kubernetes/clusters/{clusterName}/block-storages/{name}/stats
  /// </summary>
  Task<JsonElement> GetBlockStorageStatisticsAsync(string clusterName, string name, Apigen.TransIp.Models.GetBlockStorageStatisticsRequest getBlockStorageStatisticsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all events
  /// Operation: GET /kubernetes/clusters/{clusterName}/events
  /// </summary>
  Task<JsonElement> ListAllEventsAsync(string clusterName, CancellationToken cancellationToken = default);

  /// <summary>
  /// List an event
  /// Operation: GET /kubernetes/clusters/{clusterName}/events/{name}
  /// </summary>
  Task<JsonElement> GetAsync(string clusterName, string name, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get KubeConfig for Cluster
  /// Operation: GET /kubernetes/clusters/{clusterName}/kube-config
  /// </summary>
  Task<JsonElement> GetKubeConfigClusterAsync(string clusterName, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all LoadBalancers
  /// Operation: GET /kubernetes/clusters/{clusterName}/load-balancers
  /// </summary>
  Task<JsonElement> ListAllLoadBalancersAsync(string clusterName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Add a LoadBalancer
  /// Operation: POST /kubernetes/clusters/{clusterName}/load-balancers
  /// </summary>
  Task AddLoadBalancerAsync(string clusterName, Apigen.TransIp.Models.AddLoadBalancerRequest addLoadBalancerRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Remove a LoadBalancer
  /// Operation: DELETE /kubernetes/clusters/{clusterName}/load-balancers/{name}
  /// </summary>
  Task DeleteKubernetesClustersLoadBalancersAsync(string clusterName, string name, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get LoadBalancer info
  /// Operation: GET /kubernetes/clusters/{clusterName}/load-balancers/{name}
  /// </summary>
  Task<JsonElement> GetKubernetesClustersLoadBalancersAsync(string clusterName, string name, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update a loadBalancer
  /// Operation: PUT /kubernetes/clusters/{clusterName}/load-balancers/{name}
  /// </summary>
  Task UpdateAsync(string clusterName, string name, Apigen.TransIp.Models.UpdateLoadBalancerRequest updateLoadBalancerRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all LoadBalancer status reports
  /// Operation: GET /kubernetes/clusters/{clusterName}/load-balancers/{name}/status-reports
  /// </summary>
  Task<JsonElement> ListAllLoadBalancerStatusReportsAsync(string clusterName, string name, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get LoadBalancer info
  /// Operation: GET /kubernetes/clusters/{clusterName}/load-balancers/{name}/status-reports/{nodeUuid}
  /// </summary>
  Task<JsonElement> GetAsync(string clusterName, string name, string nodeUuid, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all nodepools
  /// Operation: GET /kubernetes/clusters/{clusterName}/node-pools
  /// </summary>
  Task<JsonElement> ListAllNodepoolsAsync(string clusterName, CancellationToken cancellationToken = default);

  /// <summary>
  /// Add nodepool
  /// Operation: POST /kubernetes/clusters/{clusterName}/node-pools
  /// </summary>
  Task<JsonElement> AddNodepoolAsync(string clusterName, Apigen.TransIp.Models.AddNodepoolRequest addNodepoolRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Remove nodepool
  /// Operation: DELETE /kubernetes/clusters/{clusterName}/node-pools/{uuid}
  /// </summary>
  Task DeleteKubernetesClustersNodePoolsAsync(string clusterName, string uuid, CancellationToken cancellationToken = default);

  /// <summary>
  /// List single nodepool
  /// Operation: GET /kubernetes/clusters/{clusterName}/node-pools/{uuid}
  /// </summary>
  Task<JsonElement> GetKubernetesClustersNodePoolsAsync(string clusterName, string uuid, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update nodepool
  /// Operation: PUT /kubernetes/clusters/{clusterName}/node-pools/{uuid}
  /// </summary>
  Task UpdateAsync(string clusterName, string uuid, Apigen.TransIp.Models.UpdateNodepoolRequest updateNodepoolRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all labels
  /// Operation: GET /kubernetes/clusters/{clusterName}/node-pools/{uuid}/labels
  /// </summary>
  Task<JsonElement> ListAllLabelsAsync(string clusterName, string uuid, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update labels
  /// Operation: PUT /kubernetes/clusters/{clusterName}/node-pools/{uuid}/labels
  /// </summary>
  Task UpdateLabelsAsync(string clusterName, string uuid, Apigen.TransIp.Models.UpdateLabelsRequest updateLabelsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all taints
  /// Operation: GET /kubernetes/clusters/{clusterName}/node-pools/{uuid}/taints
  /// </summary>
  Task<JsonElement> ListAllTaintsAsync(string clusterName, string uuid, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update taints
  /// Operation: PUT /kubernetes/clusters/{clusterName}/node-pools/{uuid}/taints
  /// </summary>
  Task UpdateTaintsAsync(string clusterName, string uuid, Apigen.TransIp.Models.UpdateTaintsRequest updateTaintsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all nodes
  /// Operation: GET /kubernetes/clusters/{clusterName}/nodes
  /// </summary>
  Task<JsonElement> ListAllNodesAsync(string clusterName, Apigen.TransIp.Models.ListAllNodesRequest listAllNodesRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List single node
  /// Operation: GET /kubernetes/clusters/{clusterName}/nodes/{uuid}
  /// </summary>
  Task<JsonElement> GetKubernetesClustersNodesAsync(string clusterName, string uuid, CancellationToken cancellationToken = default);

  /// <summary>
  /// Reboot a node
  /// Operation: PATCH /kubernetes/clusters/{clusterName}/nodes/{uuid}
  /// </summary>
  Task RebootNodeAsync(string clusterName, string uuid, Apigen.TransIp.Models.RebootNodeRequest rebootNodeRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get node statistics
  /// Operation: GET /kubernetes/clusters/{clusterName}/nodes/{uuid}/stats
  /// </summary>
  Task<JsonElement> GetNodeStatisticsAsync(string clusterName, string uuid, Apigen.TransIp.Models.GetNodeStatisticsRequest getNodeStatisticsRequest, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all available Kubernetes releases
  /// Operation: GET /kubernetes/clusters/{clusterName}/releases
  /// </summary>
  Task<JsonElement> ListAllAvailableKubernetesReleasesAsync(string clusterName, CancellationToken cancellationToken = default);

  /// <summary>
  /// List a single Kubernetes release
  /// Operation: GET /kubernetes/clusters/{clusterName}/releases/{version}
  /// </summary>
  Task<JsonElement> GetKubernetesClustersReleasesAsync(string clusterName, string version, CancellationToken cancellationToken = default);

  /// <summary>
  /// List kubernetes products
  /// Operation: GET /kubernetes/products
  /// </summary>
  Task<JsonElement> ListKubernetesProductsAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Get information about a Kubernetes product
  /// Operation: GET /kubernetes/products/{product}
  /// </summary>
  Task<JsonElement> GetKubernetesProductsAsync(string product, CancellationToken cancellationToken = default);

  /// <summary>
  /// List all available Kubernetes releases
  /// Operation: GET /kubernetes/releases
  /// </summary>
  Task<JsonElement> ListAllAvailableKubernetesReleasesAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// List a single Kubernetes release
  /// Operation: GET /kubernetes/releases/{version}
  /// </summary>
  Task<JsonElement> GetKubernetesReleasesAsync(string version, CancellationToken cancellationToken = default);

}
