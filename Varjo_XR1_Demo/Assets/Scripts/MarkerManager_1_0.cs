using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Varjo.XR;

public class MarkerManager_1_0 : MonoBehaviour
{
    private List<VarjoMarker> markers;
    private List<long> markerIds;
    private List<long> absentIds;
    private Dictionary<long, MarkerVisualizer> markerVisualizers;
    public VarjoMarker marker;

    public Transform xrRig;
    public GameObject markerPrefab;

    public bool markersEnabled = true;
    private bool _markersEnabled;

    private Transform markerTransform;
    // Start is called before the first frame update
    void Start()
    {
        markers = new List<VarjoMarker>();
        markerIds = new List<long>();
        markerVisualizers = new Dictionary<long, MarkerVisualizer>();
        marker = new VarjoMarker();


    }

    // Update is called once per frame
    void Update()
    {
        
        if(markersEnabled != _markersEnabled)
        {
            markersEnabled = VarjoMarkers.EnableVarjomarkers(markersEnabled);
            _markersEnabled = markersEnabled;
        }

        if (VarjoMarkers.IsVarjoMarkersEnabled())
        {
            markers.Clear();
            markerIds.Clear();
            int foundMarkers = VarjoMarkers.GetVarjoMarkers(out markers);
            if (markers.Count > 0)
            {
                foreach( var marker in markers)
                {

                }
            }
        }

    }
}
