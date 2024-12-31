using System;
using System.Collections;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GetHardwareInfo
{
    public partial class LicenseForm : Form
    {
        #region Enumerations
        public enum HardwareClasses
        {
            Win32_1394Controller,
            Win32_1394ControllerDevice,
            Win32_BaseBoard,
            Win32_Battery,
            Win32_BIOS,
            Win32_Bus,
            Win32_CDROMDrive,
            //Win32_CIMLogicalDeviceCIMDataFile,
            //Win32_DeviceBus,
            //Win32_DeviceMemoryAddress,
            Win32_DeviceSettings,
            Win32_DisplayConfiguration,
            Win32_DisplayControllerConfiguration,
            Win32_DMAChannel,
            Win32_DriverVXD,
            Win32_FloppyController,
            Win32_FloppyDrive,
            Win32_HeatPipe,
            Win32_IDEController,
            Win32_IDEControllerDevice,
            Win32_InfraredDevice,
            Win32_IRQResource,
            Win32_Keyboard,
            Win32_MotherboardDevice,
            Win32_OnBoardDevice,
            Win32_PCMCIAController,
            Win32_PNPAllocatedResource,
            Win32_PnPDevice,
            Win32_PnPEntity,
            Win32_PointingDevice,
            Win32_PortableBattery,
            Win32_PortConnector,
            Win32_PortResource,
            Win32_POTSModem,
            Win32_POTSModemToSerialPort,
            Win32_PowerManagementEvent,
            //Win32_Printer,
            //Win32_PrinterConfiguration,
            //Win32_PrinterController,
            //Win32_PrinterDriverDll,
            //Win32_PrinterSetting,
            //Win32_PrinterShare,
            //Win32_PrintJob,
            Win32_Processor,
            Win32_SCSIController,
            Win32_SCSIControllerDevice,
            Win32_SerialPort,
            Win32_SerialPortConfiguration,
            Win32_SerialPortSetting,
            Win32_SMBIOSMemory,
            Win32_SoundDevice,
            Win32_TemperatureProbe,
            Win32_USBController,
            Win32_USBControllerDevice,
            Win32_VideoConfiguration,
            Win32_VideoController,
            Win32_VideoSettings,
            Win32_VoltageProbe
        }
        public enum StorageClasses
        {
            Win32_DiskDrive,
            Win32_DiskDriveToDiskPartition,
            Win32_DiskPartition,
            //Win32_LogicalDisk,
            //Win32_LogicalDiskRootDirectory,
            //Win32_LogicalDiskToPartition,
            //Win32_LogicalFileAccess,
            //Win32_LogicalFileAuditing,
            //Win32_LogicalFileGroup,
            //Win32_LogicalFileOwner,
            //Win32_LogicalFileSecuritySetting,
            //Win32_TapeDrive
        }
        public enum MemoryClasses
        {
            Win32_CacheMemory,
            Win32_MemoryArray,
            Win32_MemoryArrayLocation,
            Win32_MemoryDevice,
            Win32_MemoryDeviceArray,
            Win32_MemoryDeviceLocation,
            Win32_AssociatedProcessorMemory,
            Win32_DeviceMemoryAddress,
            Win32_LogicalMemoryConfiguration,
            Win32_PerfRawData_PerfOS_Memory,
            Win32_PhysicalMemory,
            Win32_PhysicalMemoryArray,
            Win32_PhysicalMemoryLocation,
            Win32_SMBIOSMemory,
            Win32_SystemLogicalMemoryConfiguration,
            Win32_SystemMemoryResource
        }
        public enum SystemInfoClasses
        {
            Win32_ACE,
            Win32_ActionCheck,
            Win32_AllocatedResource,
            Win32_ApplicationCommandLine,
            Win32_ApplicationService,
            Win32_Account,
            Win32_AccountSID,
            Win32_AssociatedBattery,
            Win32_AssociatedProcessorMemory,
            Win32_Process,
            Win32_ProcessStartup,
            Win32_Product,
            Win32_ProductCheck,
            Win32_ProductResource,
            Win32_ProductSoftwareFeatures,
            Win32_ProgIDSpecification,
            Win32_ProgramGroup,
            Win32_ProgramGroupContents,
            Win32_ProgramGroupOrItem,
            Win32_Property,
            Win32_ProtocolBinding,
            Win32_PublishComponentAction,
            Win32_QuickFixEngineering,
            Win32_Refrigeration,
            Win32_Registry,
            Win32_RegistryAction,
            Win32_SystemAccount,
            Win32_SystemBIOS,
            Win32_SystemBootConfiguration,
            Win32_SystemDesktop,
            Win32_SystemDevices,
            Win32_SystemDriver,
            Win32_SystemDriverPNPEntity,
            Win32_SystemEnclosure,
            Win32_SystemLoadOrderGroups,
            Win32_SystemLogicalMemoryConfiguration,
            Win32_SystemMemoryResource,
            Win32_SystemOperatingSystem,
            Win32_SystemPartitions,
            Win32_SystemProcesses,
            Win32_SystemProgramGroups,
            Win32_SystemResources,
            Win32_SystemServices,
            Win32_SystemSetting,
            Win32_SystemSlot,
            Win32_SystemSystemDriver,
            Win32_SystemTimeZone,
            Win32_ComputerSystem,
            Win32_ComputerSystemProcessor,
            Win32_ComputerSystemProduct,
            Win32_Service,
            Win32_ServiceControl,
            Win32_ServiceSpecification,
            Win32_ServiceSpecificationService
        }
        public enum NetworkClasses
        {
            Win32_NetworkAdapter,
            Win32_NetworkAdapterConfiguration,
            Win32_NetworkAdapterSetting,
            Win32_NetworkClient,
            Win32_NetworkConnection,
            Win32_NetworkLoginProfile,
            Win32_NetworkProtocol,
            Win32_PerfRawData_Tcpip_ICMP,
            Win32_PerfRawData_Tcpip_IP,
            Win32_PerfRawData_Tcpip_NBTConnection,
            Win32_PerfRawData_Tcpip_NetworkInterface,
            Win32_PerfRawData_Tcpip_TCP,
            Win32_PerfRawData_Tcpip_UDP,
            Win32_PerfRawData_W3SVC_WebService,
            Win32_SystemNetworkConnections
        }
        public enum UserClasses
        {
            Win32_SystemUsers,
            Win32_Account,
            Win32_AccountSID,
            //Win32_SecurityDescriptor,
            //Win32_SecuritySetting,
            //Win32_SecuritySettingAccess,
            //Win32_SecuritySettingAuditing,
            //Win32_SecuritySettingGroup,
            //Win32_SecuritySettingOfLogicalFile,
            //Win32_SecuritySettingOfLogicalShare,
            //Win32_SecuritySettingOfObject,
            //Win32_SecuritySettingOwner,
            //Win32_NTEventlogFile,
            //Win32_NTLogEvent,
            //Win32_NTLogEventComputer,
            //Win32_NTLogEventLog,
            //Win32_NTLogEventUser
        }
        public enum DeveloperClasses
        {
            Win32_COMApplication,
            Win32_COMApplicationClasses,
            Win32_COMApplicationSettings,
            Win32_COMClass,
            Win32_ComClassAutoEmulator,
            Win32_ComClassEmulator,
            Win32_COMSetting,
            Win32_ODBCAttribute,
            Win32_ODBCDataSourceAttribute,
            Win32_ODBCDataSourceSpecification,
            Win32_ODBCDriverAttribute,
            Win32_ODBCDriverSoftwareElement,
            Win32_ODBCDriverSpecification,
            Win32_ODBCSourceAttribute,
            Win32_ODBCTranslatorSpecification,
            Win32_Perf,
            Win32_PerfRawData,
            Win32_PerfRawData_ASP_ActiveServerPages,
            Win32_PerfRawData_ASPNET_114322_ASPNETAppsv114322,
            Win32_PerfRawData_ASPNET_114322_ASPNETv114322,
            Win32_PerfRawData_ASPNET_ASPNET,
            Win32_PerfRawData_ASPNET_ASPNETApplications,
            Win32_PerfRawData_IAS_IASAccountingClients,
            Win32_PerfRawData_IAS_IASAccountingServer,
            Win32_PerfRawData_IAS_IASAuthenticationClients,
            Win32_PerfRawData_IAS_IASAuthenticationServer,
            Win32_PerfRawData_InetInfo_InternetInformationServicesGlobal,
            Win32_PerfRawData_MSDTC_DistributedTransactionCoordinator,
            Win32_PerfRawData_MSFTPSVC_FTPService,
            Win32_PerfRawData_MSSQLSERVER_SQLServerAccessMethods,
            Win32_PerfRawData_MSSQLSERVER_SQLServerBackupDevice,
            Win32_PerfRawData_MSSQLSERVER_SQLServerBufferManager,
            Win32_PerfRawData_MSSQLSERVER_SQLServerBufferPartition,
            Win32_PerfRawData_MSSQLSERVER_SQLServerCacheManager,
            Win32_PerfRawData_MSSQLSERVER_SQLServerDatabases,
            Win32_PerfRawData_MSSQLSERVER_SQLServerGeneralStatistics,
            Win32_PerfRawData_MSSQLSERVER_SQLServerLatches,
            Win32_PerfRawData_MSSQLSERVER_SQLServerLocks,
            Win32_PerfRawData_MSSQLSERVER_SQLServerMemoryManager,
            Win32_PerfRawData_MSSQLSERVER_SQLServerReplicationAgents,
            Win32_PerfRawData_MSSQLSERVER_SQLServerReplicationDist,
            Win32_PerfRawData_MSSQLSERVER_SQLServerReplicationLogreader,
            Win32_PerfRawData_MSSQLSERVER_SQLServerReplicationMerge,
            Win32_PerfRawData_MSSQLSERVER_SQLServerReplicationSnapshot,
            Win32_PerfRawData_MSSQLSERVER_SQLServerSQLStatistics,
            Win32_PerfRawData_MSSQLSERVER_SQLServerUserSettable,
            Win32_PerfRawData_NETFramework_NETCLRExceptions,
            Win32_PerfRawData_NETFramework_NETCLRInterop,
            Win32_PerfRawData_NETFramework_NETCLRJit,
            Win32_PerfRawData_NETFramework_NETCLRLoading,
            Win32_PerfRawData_NETFramework_NETCLRLocksAndThreads,
            Win32_PerfRawData_NETFramework_NETCLRMemory,
            Win32_PerfRawData_NETFramework_NETCLRRemoting,
            Win32_PerfRawData_NETFramework_NETCLRSecurity,
            Win32_PerfRawData_Outlook_Outlook,
            Win32_PerfRawData_PerfDisk_PhysicalDisk,
            Win32_PerfRawData_PerfNet_Browser,
            Win32_PerfRawData_PerfNet_Redirector,
            Win32_PerfRawData_PerfNet_Server,
            Win32_PerfRawData_PerfNet_ServerWorkQueues,
            Win32_PerfRawData_PerfOS_Cache,
            Win32_PerfRawData_PerfOS_Memory,
            Win32_PerfRawData_PerfOS_Objects,
            Win32_PerfRawData_PerfOS_PagingFile,
            Win32_PerfRawData_PerfOS_Processor,
            Win32_PerfRawData_PerfOS_System,
            Win32_PerfRawData_PerfProc_FullImage_Costly,
            Win32_PerfRawData_PerfProc_Image_Costly,
            Win32_PerfRawData_PerfProc_JobObject,
            Win32_PerfRawData_PerfProc_JobObjectDetails,
            Win32_PerfRawData_PerfProc_Process,
            Win32_PerfRawData_PerfProc_ProcessAddressSpace_Costly,
            Win32_PerfRawData_PerfProc_Thread,
            Win32_PerfRawData_PerfProc_ThreadDetails_Costly,
            Win32_PerfRawData_RemoteAccess_RASPort,
            Win32_PerfRawData_RemoteAccess_RASTotal,
            Win32_PerfRawData_RSVP_ACSPerRSVPService,
            Win32_PerfRawData_Spooler_PrintQueue,
            Win32_PerfRawData_TapiSrv_Telephony,
            Win32_SoftwareElement,
            Win32_SoftwareElementAction,
            Win32_SoftwareElementCheck,
            Win32_SoftwareElementCondition,
            Win32_SoftwareElementResource,
            Win32_SoftwareFeature,
            Win32_SoftwareFeatureAction,
            Win32_SoftwareFeatureCheck,
            Win32_SoftwareFeatureParent,
            Win32_SoftwareFeatureSoftwareElements,
            Win32_ClassicCOMApplicationClasses,
            Win32_ClassicCOMClass,
            Win32_ClassicCOMClassSetting,
            Win32_ClassicCOMClassSettings,
            Win32_ClassInfoAction,
            Win32_ClientApplicationSetting,
            Win32_CodecFile,
            Win32_DCOMApplication,
            Win32_DCOMApplicationAccessAllowedSetting,
            Win32_DCOMApplicationLaunchAllowedSetting,
            Win32_DCOMApplicationSetting
        }
        #endregion

        public LicenseForm()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InsertInfo("Win32_Processor", true);
            InsertInfo("Win32_DiskDrive", true);
            InsertInfo("Win32_NetworkAdapter", true);
            InsertInfo("Win32_PhysicalMemory", true);
            //foreach(string enumstring in Enum.GetNames(typeof(HardwareClasses))) InsertInfo(enumstring, ref this.lstDisplayHardware, true);
        }

        private void InsertInfo(string Key, bool DontInsertNull)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + Key);
            try
            {
                foreach (ManagementObject share in searcher.Get())
                {
                    if (share.Properties.Count <= 0) return;
                    foreach (PropertyData PC in share.Properties)
                    {
                        string valstr = "";
                        if (PC.Value != null && PC.Value.ToString() != "")
                        {
                            switch (PC.Value.GetType().ToString())
                            {
                                case "System.String[]":
                                    string[] str = (string[])PC.Value;
                                    string str2 = "";
                                    foreach (string st in str) str2 += st + " ";
                                    valstr = str2;
                                    break;
                                case "System.UInt16[]":
                                    ushort[] shortData = (ushort[])PC.Value;
                                    string tstr2 = "";
                                    foreach (ushort st in shortData) tstr2 += st.ToString() + " ";
                                    valstr = tstr2;
                                    break;
                                default:
                                    valstr = PC.Value.ToString();
                                    break;
                            }
                            DataRow row = this.PropertiesDataTable.NewRow();
                            row[dataColCategory] = Key;
                            row[dataColGroup] = share["Name"].ToString();
                            row[dataColSetting] = PC.Name;
                            row[dataColSettingValue] = valstr;
                            this.PropertiesDataTable.Rows.Add(row);
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("can't get data because of the following error \n" + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void WriteXmlButton_Click(object sender, EventArgs e)
        {
            this.PropertiesDataTable.WriteXml("Props.xml", true);
        }
    }
}