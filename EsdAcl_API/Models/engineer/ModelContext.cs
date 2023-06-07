using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EsdAcl_API.Models.engineer
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AclAccLog> AclAccLogs { get; set; } = null!;
        public virtual DbSet<AclCard> AclCards { get; set; } = null!;
        public virtual DbSet<AclCardNew> AclCardNews { get; set; } = null!;
        public virtual DbSet<AclEmp> AclEmps { get; set; } = null!;
        public virtual DbSet<AclExpConf> AclExpConfs { get; set; } = null!;
        public virtual DbSet<AclExpErr> AclExpErrs { get; set; } = null!;
        public virtual DbSet<AclGate> AclGates { get; set; } = null!;
        public virtual DbSet<AclLog> AclLogs { get; set; } = null!;
        public virtual DbSet<AclMgrDeptCode> AclMgrDeptCodes { get; set; } = null!;
        public virtual DbSet<AclRdgrp> AclRdgrps { get; set; } = null!;
        public virtual DbSet<AclRdgrpMapping> AclRdgrpMappings { get; set; } = null!;
        public virtual DbSet<AclTranType> AclTranTypes { get; set; } = null!;
        public virtual DbSet<BbArea> BbAreas { get; set; } = null!;
        public virtual DbSet<BbCatDetail> BbCatDetails { get; set; } = null!;
        public virtual DbSet<BbCategory> BbCategories { get; set; } = null!;
        public virtual DbSet<BbEqm> BbEqms { get; set; } = null!;
        public virtual DbSet<BbEqmType> BbEqmTypes { get; set; } = null!;
        public virtual DbSet<BbFileUpload> BbFileUploads { get; set; } = null!;
        public virtual DbSet<BbImg> BbImgs { get; set; } = null!;
        public virtual DbSet<BbInvReq> BbInvReqs { get; set; } = null!;
        public virtual DbSet<BbInvSupport> BbInvSupports { get; set; } = null!;
        public virtual DbSet<BbLine> BbLines { get; set; } = null!;
        public virtual DbSet<BbMap> BbMaps { get; set; } = null!;
        public virtual DbSet<BbMdEff> BbMdEffs { get; set; } = null!;
        public virtual DbSet<BbMdEffItem> BbMdEffItems { get; set; } = null!;
        public virtual DbSet<BbMsgToUser> BbMsgToUsers { get; set; } = null!;
        public virtual DbSet<BbMsgToUserBak> BbMsgToUserBaks { get; set; } = null!;
        public virtual DbSet<BbPmF1> BbPmF1s { get; set; } = null!;
        public virtual DbSet<BbPmF2Hearder> BbPmF2Hearders { get; set; } = null!;
        public virtual DbSet<BbPmF2Item> BbPmF2Items { get; set; } = null!;
        public virtual DbSet<BbPmF3> BbPmF3s { get; set; } = null!;
        public virtual DbSet<BbPmF4> BbPmF4s { get; set; } = null!;
        public virtual DbSet<BbPmF5> BbPmF5s { get; set; } = null!;
        public virtual DbSet<BbPmF6> BbPmF6s { get; set; } = null!;
        public virtual DbSet<BbPmF7> BbPmF7s { get; set; } = null!;
        public virtual DbSet<BbPmF8> BbPmF8s { get; set; } = null!;
        public virtual DbSet<BbPmScheduled> BbPmScheduleds { get; set; } = null!;
        public virtual DbSet<BbProdGrp> BbProdGrps { get; set; } = null!;
        public virtual DbSet<BbReqPriority> BbReqPriorities { get; set; } = null!;
        public virtual DbSet<BbStation> BbStations { get; set; } = null!;
        public virtual DbSet<BbSupAreaConf> BbSupAreaConfs { get; set; } = null!;
        public virtual DbSet<BbWbAnswer> BbWbAnswers { get; set; } = null!;
        public virtual DbSet<BbWbQcat> BbWbQcats { get; set; } = null!;
        public virtual DbSet<BbWbQuestion> BbWbQuestions { get; set; } = null!;
        public virtual DbSet<BbWorkTime> BbWorkTimes { get; set; } = null!;
        public virtual DbSet<EsdBuildingInfo> EsdBuildingInfos { get; set; } = null!;
        public virtual DbSet<EsdEmpLeave> EsdEmpLeaves { get; set; } = null!;
        public virtual DbSet<EsdEmpPrdlist> EsdEmpPrdlists { get; set; } = null!;
        public virtual DbSet<EsdEmpPrdlistNew> EsdEmpPrdlistNews { get; set; } = null!;
        public virtual DbSet<EsdEmpTmplist> EsdEmpTmplists { get; set; } = null!;
        public virtual DbSet<EsdEmpTmplistNew> EsdEmpTmplistNews { get; set; } = null!;
        public virtual DbSet<EsdGofSt> EsdGofSts { get; set; } = null!;
        public virtual DbSet<EsdLog> EsdLogs { get; set; } = null!;
        public virtual DbSet<EsdLogFile> EsdLogFiles { get; set; } = null!;
        public virtual DbSet<EsdLogsArc> EsdLogsArcs { get; set; } = null!;
        public virtual DbSet<EsdLogsArcR1> EsdLogsArcR1s { get; set; } = null!;
        public virtual DbSet<EsdLogsCheck> EsdLogsChecks { get; set; } = null!;
        public virtual DbSet<EsdLogsNew1> EsdLogsNew1s { get; set; } = null!;
        public virtual DbSet<EsdRemark> EsdRemarks { get; set; } = null!;
        public virtual DbSet<EsdSiteInfo> EsdSiteInfos { get; set; } = null!;
        public virtual DbSet<EsdSourceInfo> EsdSourceInfos { get; set; } = null!;
        public virtual DbSet<LibraryCisco> LibraryCiscos { get; set; } = null!;
        public virtual DbSet<LibraryHp> LibraryHps { get; set; } = null!;
        public virtual DbSet<LibraryMatrox> LibraryMatroxes { get; set; } = null!;
        public virtual DbSet<LibraryMaxtor> LibraryMaxtors { get; set; } = null!;
        public virtual DbSet<LibraryNeec> LibraryNeecs { get; set; } = null!;
        public virtual DbSet<LibraryNokium> LibraryNokia { get; set; } = null!;
        public virtual DbSet<LibraryNvidium> LibraryNvidia { get; set; } = null!;
        public virtual DbSet<LibraryPolycom> LibraryPolycoms { get; set; } = null!;
        public virtual DbSet<Manpowerst> Manpowersts { get; set; } = null!;
        public virtual DbSet<Micro> Micros { get; set; } = null!;
        public virtual DbSet<Productionhl> Productionhls { get; set; } = null!;
        public virtual DbSet<SmtCustomer> SmtCustomers { get; set; } = null!;
        public virtual DbSet<SmtProduct> SmtProducts { get; set; } = null!;
        public virtual DbSet<SmtProfile> SmtProfiles { get; set; } = null!;
        public virtual DbSet<SmtStencil> SmtStencils { get; set; } = null!;
        public virtual DbSet<TjArea> TjAreas { get; set; } = null!;
        public virtual DbSet<TjCatDetail> TjCatDetails { get; set; } = null!;
        public virtual DbSet<TjCategory> TjCategories { get; set; } = null!;
        public virtual DbSet<TjEqm> TjEqms { get; set; } = null!;
        public virtual DbSet<TjEqmType> TjEqmTypes { get; set; } = null!;
        public virtual DbSet<TjFileUpload> TjFileUploads { get; set; } = null!;
        public virtual DbSet<TjImg> TjImgs { get; set; } = null!;
        public virtual DbSet<TjInvReq> TjInvReqs { get; set; } = null!;
        public virtual DbSet<TjInvSupport> TjInvSupports { get; set; } = null!;
        public virtual DbSet<TjLine> TjLines { get; set; } = null!;
        public virtual DbSet<TjMap> TjMaps { get; set; } = null!;
        public virtual DbSet<TjMdEff> TjMdEffs { get; set; } = null!;
        public virtual DbSet<TjMdEffItem> TjMdEffItems { get; set; } = null!;
        public virtual DbSet<TjMsgToUser> TjMsgToUsers { get; set; } = null!;
        public virtual DbSet<TjPmF1> TjPmF1s { get; set; } = null!;
        public virtual DbSet<TjPmF2Hearder> TjPmF2Hearders { get; set; } = null!;
        public virtual DbSet<TjPmF2Item> TjPmF2Items { get; set; } = null!;
        public virtual DbSet<TjPmF3> TjPmF3s { get; set; } = null!;
        public virtual DbSet<TjPmF4> TjPmF4s { get; set; } = null!;
        public virtual DbSet<TjPmF5> TjPmF5s { get; set; } = null!;
        public virtual DbSet<TjPmF6> TjPmF6s { get; set; } = null!;
        public virtual DbSet<TjPmF7> TjPmF7s { get; set; } = null!;
        public virtual DbSet<TjPmF8> TjPmF8s { get; set; } = null!;
        public virtual DbSet<TjPmScheduled> TjPmScheduleds { get; set; } = null!;
        public virtual DbSet<TjProdGrp> TjProdGrps { get; set; } = null!;
        public virtual DbSet<TjReqPriority> TjReqPriorities { get; set; } = null!;
        public virtual DbSet<TjStation> TjStations { get; set; } = null!;
        public virtual DbSet<TjSupAreaConf> TjSupAreaConfs { get; set; } = null!;
        public virtual DbSet<TjWbAnswer> TjWbAnswers { get; set; } = null!;
        public virtual DbSet<TjWbQcat> TjWbQcats { get; set; } = null!;
        public virtual DbSet<TjWbQuestion> TjWbQuestions { get; set; } = null!;
        public virtual DbSet<TjWorkTime> TjWorkTimes { get; set; } = null!;
        public virtual DbSet<ToadPlanTable> ToadPlanTables { get; set; } = null!;
        public virtual DbSet<VEmplist> VEmplists { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST= cthorap21.th-lcb.celestica.com)(PORT=1523))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=apps))); User ID=engineer;Password=pcjaws5t");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("ENGINEER")
                .UseCollation("USING_NLS_COMP");

            modelBuilder.Entity<AclAccLog>(entity =>
            {
                entity.HasKey(e => e.AclAccId)
                    .HasName("ACL_ACC_LOGS_PK");

                entity.ToTable("ACL_ACC_LOGS");

                entity.Property(e => e.AclAccId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ACL_ACC_ID");

                entity.Property(e => e.AccBy)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ACC_BY");

                entity.Property(e => e.AccDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACC_DATE");

                entity.Property(e => e.AccEmpNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACC_EMP_NO");

                entity.Property(e => e.AccInfo)
                    .HasMaxLength(1200)
                    .IsUnicode(false)
                    .HasColumnName("ACC_INFO");

                entity.Property(e => e.AclGateId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ACL_GATE_ID");

                entity.Property(e => e.BackNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BACK_NO");

                entity.Property(e => e.CardId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARD_ID");

                entity.Property(e => e.FrontNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FRONT_NO");
            });

            modelBuilder.Entity<AclCard>(entity =>
            {
                entity.HasKey(e => e.CardId)
                    .HasName("PK_ACLCARD");

                entity.ToTable("ACL_CARD");

                entity.HasIndex(e => e.EmpNo, "IDX_ACLCARD_EMPNO");

                entity.Property(e => e.CardId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARD_ID")
                    .IsFixedLength();

                entity.Property(e => e.AclCardActdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACL_CARD_ACTDATE");

                entity.Property(e => e.BackNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BACK_NO");

                entity.Property(e => e.CardSts)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CARD_STS")
                    .HasDefaultValueSql("'ACT'");

                entity.Property(e => e.CardType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARD_TYPE");

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_CODE");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_NAME");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("EMP_NAME");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EMP_NO");

                entity.Property(e => e.FrontNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FRONT_NO");

                entity.Property(e => e.Handicap)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HANDICAP")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.LastRemark)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LAST_REMARK");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE");

                entity.Property(e => e.Position)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("POSITION");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateFlag)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_FLAG")
                    .IsFixedLength();
            });

            modelBuilder.Entity<AclCardNew>(entity =>
            {
                entity.HasKey(e => e.CardId);

                entity.ToTable("ACL_CARD_NEW");

                entity.Property(e => e.CardId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARD_ID")
                    .IsFixedLength();

                entity.Property(e => e.AclCardActdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACL_CARD_ACTDATE");

                entity.Property(e => e.BackNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BACK_NO");

                entity.Property(e => e.CardSts)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CARD_STS")
                    .HasDefaultValueSql("'ACT'");

                entity.Property(e => e.CardType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARD_TYPE");

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_CODE");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_NAME");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("EMP_NAME");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EMP_NO");

                entity.Property(e => e.FrontNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FRONT_NO");

                entity.Property(e => e.Handicap)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HANDICAP")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.LastRemark)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LAST_REMARK");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("DATE")
                    .HasColumnName("LAST_UPDATE");

                entity.Property(e => e.Position)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("POSITION");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateFlag)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_FLAG")
                    .IsFixedLength();
            });

            modelBuilder.Entity<AclEmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACL_EMP");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EMP_NO");
            });

            modelBuilder.Entity<AclExpConf>(entity =>
            {
                entity.HasKey(e => e.AclexpId)
                    .HasName("ESD_ACLEXP_CONF_PK");

                entity.ToTable("ACL_EXP_CONF");

                entity.Property(e => e.AclexpId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ACLEXP_ID");

                entity.Property(e => e.AclTrantypeId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ACL_TRANTYPE_ID");

                entity.Property(e => e.AclexpEmail)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ACLEXP_EMAIL");

                entity.Property(e => e.AclexpLastUpdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACLEXP_LAST_UPDATE");

                entity.Property(e => e.AclexpPath)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ACLEXP_PATH");

                entity.Property(e => e.AclexpSts)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ACLEXP_STS")
                    .HasDefaultValueSql("'ACT'");

                entity.Property(e => e.Building)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BUILDING");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_NAME");

                entity.Property(e => e.GateType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GATE_TYPE");

                entity.Property(e => e.MapdrivePass)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MAPDRIVE_PASS");

                entity.Property(e => e.MapdriveUser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MAPDRIVE_USER");

                entity.Property(e => e.ReaderType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("READER_TYPE");
            });

            modelBuilder.Entity<AclExpErr>(entity =>
            {
                entity.ToTable("ACL_EXP_ERR");

                entity.Property(e => e.AclexpErrId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ACLEXP_ERR_ID");

                entity.Property(e => e.AclexpErrDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ACLEXP_ERR_DATE");

                entity.Property(e => e.AclexpErrDesc)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ACLEXP_ERR_DESC");

                entity.Property(e => e.AclexpId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ACLEXP_ID");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_NAME");
            });

            modelBuilder.Entity<AclGate>(entity =>
            {
                entity.ToTable("ACL_GATE");

                entity.Property(e => e.AclGateId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ACL_GATE_ID");

                entity.Property(e => e.AclGateInfo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ACL_GATE_INFO");

                entity.Property(e => e.AclReaderInfo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ACL_READER_INFO");

                entity.Property(e => e.AclSts)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ACL_STS");
            });

            modelBuilder.Entity<AclLog>(entity =>
            {
                entity.ToTable("ACL_LOG");

                entity.Property(e => e.AclLogId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ACL_LOG_ID");

                entity.Property(e => e.AclCardId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACL_CARD_ID");

                entity.Property(e => e.AclCardType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACL_CARD_TYPE");

                entity.Property(e => e.AclLogRemark)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("ACL_LOG_REMARK");

                entity.Property(e => e.BackNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BACK_NO");

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_CODE");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_NAME");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMP_NAME");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EMP_NO");

                entity.Property(e => e.FrontNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FRONT_NO");

                entity.Property(e => e.Handicap)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("HANDICAP");

                entity.Property(e => e.LastRemark)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LAST_REMARK");

                entity.Property(e => e.Position)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("POSITION");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<AclMgrDeptCode>(entity =>
            {
                entity.HasKey(e => new { e.EmpNo, e.DeptCode })
                    .HasName("ACL_MGR_DEPT_CODE_PK");

                entity.ToTable("ACL_MGR_DEPT_CODE");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EMP_NO");

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_CODE");
            });

            modelBuilder.Entity<AclRdgrp>(entity =>
            {
                entity.ToTable("ACL_RDGRP");

                entity.Property(e => e.AclRdgrpId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ACL_RDGRP_ID");

                entity.Property(e => e.AclRdgrpCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACL_RDGRP_CODE");

                entity.Property(e => e.AclRdgrpDesc)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ACL_RDGRP_DESC");

                entity.Property(e => e.AclRdgrpSts)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ACL_RDGRP_STS")
                    .HasDefaultValueSql("'ACT'");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<AclRdgrpMapping>(entity =>
            {
                entity.HasKey(e => e.AclRdgrpMapId)
                    .HasName("ACK_RDGRP_MAP_ID_PK");

                entity.ToTable("ACL_RDGRP_MAPPING");

                entity.HasIndex(e => new { e.AclRdgrpMapId, e.AclRdgrpCode, e.CardId }, "ACL_RDGRP_MAPPING_PK")
                    .IsUnique();

                entity.Property(e => e.AclRdgrpMapId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ACL_RDGRP_MAP_ID");

                entity.Property(e => e.AclRdgrpCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ACL_RDGRP_CODE");

                entity.Property(e => e.CardId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARD_ID");
            });

            modelBuilder.Entity<AclTranType>(entity =>
            {
                entity.ToTable("ACL_TRAN_TYPE");

                entity.Property(e => e.AclTrantypeId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ACL_TRANTYPE_ID");

                entity.Property(e => e.AclTypeDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACL_TYPE_DESC");

                entity.Property(e => e.AclTypeSts)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ACL_TYPE_STS");
            });

            modelBuilder.Entity<BbArea>(entity =>
            {
                entity.HasKey(e => e.AreaId)
                    .HasName("BB_AREA_PK");

                entity.ToTable("BB_AREA");

                entity.Property(e => e.AreaId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AREA_ID");

                entity.Property(e => e.AreaDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AREA_DESC");

                entity.Property(e => e.AreaStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AREA_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<BbCatDetail>(entity =>
            {
                entity.HasKey(e => e.CatDetailId)
                    .HasName("BB_CAT_DETAIL_PK");

                entity.ToTable("BB_CAT_DETAIL");

                entity.Property(e => e.CatDetailId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CAT_DETAIL_ID");

                entity.Property(e => e.CatId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CAT_ID");

                entity.Property(e => e.ProblemCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROBLEM_CODE");

                entity.Property(e => e.ProblemDetail)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("PROBLEM_DETAIL");

                entity.Property(e => e.ProblemStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PROBLEM_STATUS");

                entity.Property(e => e.ReqPriorityId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("REQ_PRIORITY_ID");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<BbCategory>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("BB_CATEGORIES");

                entity.ToTable("BB_CATEGORIES");

                entity.Property(e => e.CatId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CAT_ID");

                entity.Property(e => e.CatName)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("CAT_NAME");

                entity.Property(e => e.CatStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CAT_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<BbEqm>(entity =>
            {
                entity.HasKey(e => e.EqmId)
                    .HasName("BB_EQM_PK");

                entity.ToTable("BB_EQM");

                entity.Property(e => e.EqmId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("EQM_ID");

                entity.Property(e => e.EqmName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EQM_NAME");

                entity.Property(e => e.EqmStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("EQM_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<BbEqmType>(entity =>
            {
                entity.HasKey(e => e.EqmTypeId)
                    .HasName("BB_EQM_TYPE_ID");

                entity.ToTable("BB_EQM_TYPE");

                entity.Property(e => e.EqmTypeId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("EQM_TYPE_ID");

                entity.Property(e => e.EqmId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("EQM_ID");

                entity.Property(e => e.EqmPmForm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EQM_PM_FORM");

                entity.Property(e => e.EqmTypeName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EQM_TYPE_NAME");

                entity.Property(e => e.EqmTypeStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("EQM_TYPE_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<BbFileUpload>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("BB_FILE_UPLOAD_PK");

                entity.ToTable("BB_FILE_UPLOAD");

                entity.Property(e => e.FileId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("FILE_ID");

                entity.Property(e => e.FileContentType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FILE_CONTENT_TYPE");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME");

                entity.Property(e => e.FileSize)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILE_SIZE");
            });

            modelBuilder.Entity<BbImg>(entity =>
            {
                entity.HasKey(e => e.ImgId)
                    .HasName("BB_IMG_PK");

                entity.ToTable("BB_IMG");

                entity.Property(e => e.ImgId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IMG_ID");

                entity.Property(e => e.ImgDefault)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMG_DEFAULT");

                entity.Property(e => e.ImgDesc)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("IMG_DESC");

                entity.Property(e => e.ImgName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("IMG_NAME");

                entity.Property(e => e.ImgStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IMG_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<BbInvReq>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .HasName("BB_INV_REQ_PK");

                entity.ToTable("BB_INV_REQ");

                entity.Property(e => e.RequestId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("REQUEST_ID");

                entity.Property(e => e.AssignBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGN_BY");

                entity.Property(e => e.AssignByEmpNo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGN_BY_EMP_NO");

                entity.Property(e => e.AssignDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ASSIGN_DATE");

                entity.Property(e => e.CatDetailId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CAT_DETAIL_ID");

                entity.Property(e => e.CatId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CAT_ID");

                entity.Property(e => e.CompleteDate)
                    .HasColumnType("DATE")
                    .HasColumnName("COMPLETE_DATE");

                entity.Property(e => e.EmpReq)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("EMP_REQ");

                entity.Property(e => e.LineId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.MsgToUser)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("MSG_TO_USER");

                entity.Property(e => e.ProbleSolveDesc)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("PROBLE_SOLVE_DESC");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROD_ID");

                entity.Property(e => e.ReqPriorityId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("REQ_PRIORITY_ID");

                entity.Property(e => e.RequestDate)
                    .HasColumnType("DATE")
                    .HasColumnName("REQUEST_DATE");

                entity.Property(e => e.RequestDetail)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("REQUEST_DETAIL");

                entity.Property(e => e.StationId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STATION_ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<BbInvSupport>(entity =>
            {
                entity.HasKey(e => new { e.SupportId, e.RequestId, e.AssignTo })
                    .HasName("BB_INV_SUPPORT_PK");

                entity.ToTable("BB_INV_SUPPORT");

                entity.Property(e => e.SupportId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SUPPORT_ID");

                entity.Property(e => e.RequestId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("REQUEST_ID");

                entity.Property(e => e.AssignTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGN_TO");

                entity.Property(e => e.AssignToEmpNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGN_TO_EMP_NO");

                entity.Property(e => e.CallBackMsg)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("CALL_BACK_MSG");

                entity.Property(e => e.Remark)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.RootJob)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ROOT_JOB");

                entity.Property(e => e.SupportStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SUPPORT_STATUS");

                entity.Property(e => e.WorkEnd)
                    .HasColumnType("DATE")
                    .HasColumnName("WORK_END");

                entity.Property(e => e.WorkStart)
                    .HasColumnType("DATE")
                    .HasColumnName("WORK_START");
            });

            modelBuilder.Entity<BbLine>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("BB_LINE_PK");

                entity.ToTable("BB_LINE");

                entity.Property(e => e.LineId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.LineName)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("LINE_NAME");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LINE_STATUS");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROD_ID");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<BbMap>(entity =>
            {
                entity.HasKey(e => e.MapId)
                    .HasName("BB_MAP_PK");

                entity.ToTable("BB_MAP");

                entity.Property(e => e.MapId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MAP_ID");

                entity.Property(e => e.Border)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BORDER")
                    .HasDefaultValueSql("'Y'")
                    .IsFixedLength();

                entity.Property(e => e.Height)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HEIGHT");

                entity.Property(e => e.ImgId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IMG_ID");

                entity.Property(e => e.LineId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROD_ID");

                entity.Property(e => e.StationId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STATION_ID");

                entity.Property(e => e.Text)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("TEXT");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.Url)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("URL");

                entity.Property(e => e.Width)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WIDTH");

                entity.Property(e => e.X1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.X2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Y1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Y2)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BbMdEff>(entity =>
            {
                entity.HasKey(e => e.MdEffId)
                    .HasName("BB_MD_EFF_PK");

                entity.ToTable("BB_MD_EFF");

                entity.Property(e => e.MdEffId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MD_EFF_ID");

                entity.Property(e => e.MdEff)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MD_EFF");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<BbMdEffItem>(entity =>
            {
                entity.HasKey(e => e.MdEffItemId)
                    .HasName("BB_MD_EFF_ITEM_PK");

                entity.ToTable("BB_MD_EFF_ITEM");

                entity.Property(e => e.MdEffItemId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MD_EFF_ITEM_ID");

                entity.Property(e => e.MdEffId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MD_EFF_ID");

                entity.Property(e => e.NumEqm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NUM_EQM");

                entity.Property(e => e.NumEqmDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NUM_EQM_DESC");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<BbMsgToUser>(entity =>
            {
                entity.HasKey(e => e.BbMsgId)
                    .HasName("BB_MSG_TO_USER_PK1");

                entity.ToTable("BB_MSG_TO_USER");

                entity.Property(e => e.BbMsgId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("BB_MSG_ID");

                entity.Property(e => e.MsgBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSG_BY");

                entity.Property(e => e.MsgDate)
                    .HasColumnType("DATE")
                    .HasColumnName("MSG_DATE");

                entity.Property(e => e.MsgToUser)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("MSG_TO_USER");

                entity.Property(e => e.RequestId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("REQUEST_ID");

                entity.Property(e => e.SupportId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SUPPORT_ID");
            });

            modelBuilder.Entity<BbMsgToUserBak>(entity =>
            {
                entity.HasKey(e => e.BbMsgId)
                    .HasName("BB_MSG_TO_USER_PK");

                entity.ToTable("BB_MSG_TO_USER_BAK");

                entity.Property(e => e.BbMsgId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("BB_MSG_ID");

                entity.Property(e => e.MsgBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSG_BY");

                entity.Property(e => e.MsgDate)
                    .HasColumnType("DATE")
                    .HasColumnName("MSG_DATE");

                entity.Property(e => e.MsgToUser)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("MSG_TO_USER");

                entity.Property(e => e.RequestId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("REQUEST_ID");

                entity.Property(e => e.SupportId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SUPPORT_ID");
            });

            modelBuilder.Entity<BbPmF1>(entity =>
            {
                entity.HasKey(e => e.PmF1Id)
                    .HasName("BB_PM_F1_PK");

                entity.ToTable("BB_PM_F1");

                entity.Property(e => e.PmF1Id)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PM_F1_ID");

                entity.Property(e => e.ActTorque1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACT_TORQUE_1");

                entity.Property(e => e.ActTorque2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACT_TORQUE_2");

                entity.Property(e => e.ActTorque3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACT_TORQUE_3");

                entity.Property(e => e.ActTorqueAvg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACT_TORQUE_AVG");

                entity.Property(e => e.BfCalibrate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BF_CALIBRATE");

                entity.Property(e => e.BitCheck)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BIT_CHECK");

                entity.Property(e => e.BitType)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("BIT_TYPE");

                entity.Property(e => e.Ceaning)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CEANING");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Result)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RESULT");

                entity.Property(e => e.ScrewNo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SCREW_NO");

                entity.Property(e => e.Sn)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.Torque1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TORQUE_1");

                entity.Property(e => e.Torque2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TORQUE_2");
            });

            modelBuilder.Entity<BbPmF2Hearder>(entity =>
            {
                entity.HasKey(e => e.PmId)
                    .HasName("BB_PM_F2_HEARDER_PK");

                entity.ToTable("BB_PM_F2_HEARDER");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.Action)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ACTION");

                entity.Property(e => e.AirLonizerType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AIR_LONIZER_TYPE");

                entity.Property(e => e.Chk1LightSts)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CHK1_LIGHT_STS");

                entity.Property(e => e.Chk2LightSts)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CHK2_LIGHT_STS");

                entity.Property(e => e.Conclusion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CONCLUSION");

                entity.Property(e => e.ConclusionDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("CONCLUSION_DESC");

                entity.Property(e => e.Distance1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DISTANCE1");

                entity.Property(e => e.Distance2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DISTANCE2");

                entity.Property(e => e.Distance3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DISTANCE3");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Sn)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SN");
            });

            modelBuilder.Entity<BbPmF2Item>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BB_PM_F2_ITEM");

                entity.Property(e => e.Fan1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAN1");

                entity.Property(e => e.Fan2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAN2");

                entity.Property(e => e.Fan3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAN3");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_TYPE");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.Result)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RESULT");

                entity.Property(e => e.Section)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SECTION");

                entity.Property(e => e.VoltType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VOLT_TYPE");
            });

            modelBuilder.Entity<BbPmF3>(entity =>
            {
                entity.HasKey(e => e.PmF3Id)
                    .HasName("BB_PM_F3_PK");

                entity.ToTable("BB_PM_F3");

                entity.Property(e => e.PmF3Id)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PM_F3_ID");

                entity.Property(e => e.Actual)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTUAL");

                entity.Property(e => e.Gverify)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GVERIFY");

                entity.Property(e => e.ModelEffect)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_EFFECT");

                entity.Property(e => e.NumEqm)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("NUM_EQM");

                entity.Property(e => e.PmDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PM_DESC");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Result)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RESULT");

                entity.Property(e => e.Spec)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SPEC");
            });

            modelBuilder.Entity<BbPmF4>(entity =>
            {
                entity.HasKey(e => e.PmF4Id)
                    .HasName("BB_PM_F4_PK");

                entity.ToTable("BB_PM_F4");

                entity.Property(e => e.PmF4Id)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PM_F4_ID");

                entity.Property(e => e.CapActual)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CAP_ACTUAL");

                entity.Property(e => e.CapResult)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CAP_RESULT");

                entity.Property(e => e.ClrMachine)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLR_MACHINE");

                entity.Property(e => e.CocPreFilter)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COC_PRE_FILTER");

                entity.Property(e => e.GnrCheck)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GNR_CHECK");

                entity.Property(e => e.Gverify)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GVERIFY");

                entity.Property(e => e.ModelEffect)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_EFFECT");

                entity.Property(e => e.NumEqm)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("NUM_EQM");

                entity.Property(e => e.PmDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PM_DESC");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");
            });

            modelBuilder.Entity<BbPmF5>(entity =>
            {
                entity.HasKey(e => e.PmF5Id)
                    .HasName("BB_PM_F5_PK");

                entity.ToTable("BB_PM_F5");

                entity.Property(e => e.PmF5Id)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PM_F5_ID");

                entity.Property(e => e.Cbag)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CBAG");

                entity.Property(e => e.CwcsIpa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CWCS_IPA");

                entity.Property(e => e.Cwu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CWU");

                entity.Property(e => e.Gverify)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GVERIFY");

                entity.Property(e => e.ModelEffect)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_EFFECT");

                entity.Property(e => e.NumEqm)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("NUM_EQM");

                entity.Property(e => e.PmDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PM_DESC");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Vsot)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VSOT");
            });

            modelBuilder.Entity<BbPmF6>(entity =>
            {
                entity.HasKey(e => e.PmF6Id)
                    .HasName("BB_PM_F6_PK");

                entity.ToTable("BB_PM_F6");

                entity.Property(e => e.PmF6Id)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PM_F6_ID");

                entity.Property(e => e.Cwv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CWV");

                entity.Property(e => e.Gv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GV");

                entity.Property(e => e.Gverify)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GVERIFY");

                entity.Property(e => e.ModelEffect)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_EFFECT");

                entity.Property(e => e.NumEqm)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("NUM_EQM");

                entity.Property(e => e.PmDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PM_DESC");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Vfbti)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VFBTI");

                entity.Property(e => e.Vfmi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VFMI");

                entity.Property(e => e.Vfpi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VFPI");
            });

            modelBuilder.Entity<BbPmF7>(entity =>
            {
                entity.HasKey(e => e.PmF7Id)
                    .HasName("BB_PM_F7_PK");

                entity.ToTable("BB_PM_F7");

                entity.Property(e => e.PmF7Id)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PM_F7_ID");

                entity.Property(e => e.Gverify)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GVERIFY");

                entity.Property(e => e.ModelEffect)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_EFFECT");

                entity.Property(e => e.NumEqm)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("NUM_EQM");

                entity.Property(e => e.PmDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PM_DESC");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.TestRun)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TEST_RUN");

                entity.Property(e => e.Vacmb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VACMB");

                entity.Property(e => e.Vact)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VACT");

                entity.Property(e => e.Vttgcm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VTTGCM");

                entity.Property(e => e.VttgcmRs)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VTTGCM_RS");

                entity.Property(e => e.Vttgpm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VTTGPM");

                entity.Property(e => e.VttgpmRs)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VTTGPM_RS");

                entity.Property(e => e.Vttgrm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VTTGRM");

                entity.Property(e => e.VttgrmRs)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VTTGRM_RS");
            });

            modelBuilder.Entity<BbPmF8>(entity =>
            {
                entity.HasKey(e => e.PmF8Id)
                    .HasName("BB_PM_F8_PK");

                entity.ToTable("BB_PM_F8");

                entity.Property(e => e.PmF8Id)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PM_F8_ID");

                entity.Property(e => e.Cleaning)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLEANING");

                entity.Property(e => e.CvqtahsActual)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CVQTAHS_ACTUAL");

                entity.Property(e => e.CvqtahsSpec)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CVQTAHS_SPEC");

                entity.Property(e => e.Gverify)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GVERIFY");

                entity.Property(e => e.LocGr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LOC_GR");

                entity.Property(e => e.LocLy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LOC_LY");

                entity.Property(e => e.Lubricant)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LUBRICANT");

                entity.Property(e => e.ModelEffect)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_EFFECT");

                entity.Property(e => e.NumEqm)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("NUM_EQM");

                entity.Property(e => e.PmDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PM_DESC");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.RpmCantu)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RPM_CANTU");

                entity.Property(e => e.RpmRfu)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RPM_RFU");

                entity.Property(e => e.RpmTf)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RPM_TF");

                entity.Property(e => e.Snl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SNL");

                entity.Property(e => e.SpecA)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SPEC_A");

                entity.Property(e => e.SpecRs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SPEC_RS");

                entity.Property(e => e.SpecS)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SPEC_S");

                entity.Property(e => e.Vatfoc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VATFOC");

                entity.Property(e => e.Vcatrf)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VCATRF");

                entity.Property(e => e.Vci)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VCI");

                entity.Property(e => e.Vclat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VCLAT");

                entity.Property(e => e.VqosA)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VQOS_A");

                entity.Property(e => e.VqosS)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VQOS_S");

                entity.Property(e => e.Vsotps)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VSOTPS");

                entity.Property(e => e.Vtos)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VTOS");

                entity.Property(e => e.VttcA)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VTTC_A");

                entity.Property(e => e.VttcS)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VTTC_S");

                entity.Property(e => e.Vtw)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VTW");
            });

            modelBuilder.Entity<BbPmScheduled>(entity =>
            {
                entity.HasKey(e => e.PmId)
                    .HasName("BB_PM_SCHEDULED_PK");

                entity.ToTable("BB_PM_SCHEDULED");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.CompleteDate)
                    .HasColumnType("DATE")
                    .HasColumnName("COMPLETE_DATE");

                entity.Property(e => e.EqmId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("EQM_ID");

                entity.Property(e => e.EqmTypeId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("EQM_TYPE_ID");

                entity.Property(e => e.LineId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.PmDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PM_DATE");

                entity.Property(e => e.PmDesc)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("PM_DESC");

                entity.Property(e => e.PmStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PM_STATUS");

                entity.Property(e => e.PmType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PM_TYPE");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROD_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.StationId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STATION_ID");

                entity.Property(e => e.SupportBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUPPORT_BY");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<BbProdGrp>(entity =>
            {
                entity.HasKey(e => e.ProdId)
                    .HasName("BB_PROD_GRP_PK");

                entity.ToTable("BB_PROD_GRP");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROD_ID");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("PROD_NAME");

                entity.Property(e => e.ProdStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PROD_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<BbReqPriority>(entity =>
            {
                entity.HasKey(e => e.ReqPriorityId)
                    .HasName("REQ_PRIORITY_PK");

                entity.ToTable("BB_REQ_PRIORITY");

                entity.Property(e => e.ReqPriorityId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("REQ_PRIORITY_ID");

                entity.Property(e => e.ReqPriorityCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REQ_PRIORITY_CODE");

                entity.Property(e => e.ReqPriorityDesc)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("REQ_PRIORITY_DESC");

                entity.Property(e => e.ReqPriorityStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("REQ_PRIORITY_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<BbStation>(entity =>
            {
                entity.HasKey(e => e.StationId)
                    .HasName("BB_STATION_PK");

                entity.ToTable("BB_STATION");

                entity.Property(e => e.StationId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STATION_ID");

                entity.Property(e => e.LineId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROD_ID");

                entity.Property(e => e.StationName)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("STATION_NAME");

                entity.Property(e => e.StationStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("STATION_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<BbSupAreaConf>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.LoginName })
                    .HasName("BB_SUPAREA_CONF_PK");

                entity.ToTable("BB_SUP_AREA_CONF");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROD_ID");

                entity.Property(e => e.LoginName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOGIN_NAME");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<BbWbAnswer>(entity =>
            {
                entity.HasKey(e => e.AnsId)
                    .HasName("BB_WB_ANSWER_PK");

                entity.ToTable("BB_WB_ANSWER");

                entity.Property(e => e.AnsId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ANS_ID");

                entity.Property(e => e.AnsDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ANS_DATE");

                entity.Property(e => e.AnsLoginName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ANS_LOGIN_NAME");

                entity.Property(e => e.Answer)
                    .IsUnicode(false)
                    .HasColumnName("ANSWER");

                entity.Property(e => e.FileId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("FILE_ID");

                entity.Property(e => e.QId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Q_ID");
            });

            modelBuilder.Entity<BbWbQcat>(entity =>
            {
                entity.HasKey(e => e.QcatId)
                    .HasName("BB_QCAT_PK");

                entity.ToTable("BB_WB_QCAT");

                entity.Property(e => e.QcatId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("QCAT_ID");

                entity.Property(e => e.QcatDesc)
                    .IsUnicode(false)
                    .HasColumnName("QCAT_DESC");

                entity.Property(e => e.QcatStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("QCAT_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<BbWbQuestion>(entity =>
            {
                entity.HasKey(e => e.QId)
                    .HasName("BB_WB_QUESTION_PK");

                entity.ToTable("BB_WB_QUESTION");

                entity.Property(e => e.QId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Q_ID");

                entity.Property(e => e.FileId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("FILE_ID");

                entity.Property(e => e.FromShiftId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FROM_SHIFT_ID");

                entity.Property(e => e.Qanswer)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QANSWER");

                entity.Property(e => e.QcatId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("QCAT_ID");

                entity.Property(e => e.Qdate)
                    .HasColumnType("DATE")
                    .HasColumnName("QDATE");

                entity.Property(e => e.Qdetail)
                    .IsUnicode(false)
                    .HasColumnName("QDETAIL");

                entity.Property(e => e.QloginName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QLOGIN_NAME");

                entity.Property(e => e.Qreader)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QREADER");

                entity.Property(e => e.Qtopic)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("QTOPIC");

                entity.Property(e => e.ToShiftId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TO_SHIFT_ID");
            });

            modelBuilder.Entity<BbWorkTime>(entity =>
            {
                entity.HasKey(e => e.TimeId)
                    .HasName("BB_TIMESHEETS_PK");

                entity.ToTable("BB_WORK_TIME");

                entity.Property(e => e.TimeId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIME_ID");

                entity.Property(e => e.TimeDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TIME_DESC");

                entity.Property(e => e.TimeStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TIME_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<EsdBuildingInfo>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.Building })
                    .HasName("SYS_C0015544");

                entity.ToTable("ESD_BUILDING_INFO");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SITE_ID")
                    .IsFixedLength();

                entity.Property(e => e.Building)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BUILDING");
            });

            modelBuilder.Entity<EsdEmpLeave>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.LeaveId })
                    .HasName("PK_ESDLEAVE");

                entity.ToTable("ESD_EMP_LEAVE");

                entity.HasIndex(e => new { e.SiteId, e.EmpNo }, "ESD_IDX04");

                entity.HasIndex(e => e.FromDate, "ESD_IDX05");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SITE_ID")
                    .IsFixedLength();

                entity.Property(e => e.LeaveId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LEAVE_ID")
                    .IsFixedLength();

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EMP_NO")
                    .IsFixedLength();

                entity.Property(e => e.FromDate)
                    .HasColumnType("DATE")
                    .HasColumnName("FROM_DATE");

                entity.Property(e => e.LeaveCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LEAVE_CODE")
                    .IsFixedLength();

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.ToDate)
                    .HasColumnType("DATE")
                    .HasColumnName("TO_DATE");
            });

            modelBuilder.Entity<EsdEmpPrdlist>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.EmpNo })
                    .HasName("PK_EMPPRDLIST");

                entity.ToTable("ESD_EMP_PRDLIST");

                entity.HasIndex(e => new { e.SupsiteId, e.SupempNo }, "ESD_IDX03");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SITE_ID")
                    .IsFixedLength();

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EMP_NO")
                    .IsFixedLength();

                entity.Property(e => e.ApproveBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("APPROVE_BY");

                entity.Property(e => e.ApproveDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APPROVE_DATE");

                entity.Property(e => e.ApproveId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("APPROVE_ID");

                entity.Property(e => e.Building)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BUILDING");

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_CODE")
                    .IsFixedLength();

                entity.Property(e => e.PrepareBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PREPARE_BY");

                entity.Property(e => e.PrepareDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PREPARE_DATE");

                entity.Property(e => e.StsLoad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STS_LOAD")
                    .IsFixedLength();

                entity.Property(e => e.SupempNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SUPEMP_NO")
                    .IsFixedLength();

                entity.Property(e => e.SupsiteId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPSITE_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<EsdEmpPrdlistNew>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.EmpNo })
                    .HasName("SYS_C0014987");

                entity.ToTable("ESD_EMP_PRDLIST_NEW");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SITE_ID")
                    .IsFixedLength();

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EMP_NO")
                    .IsFixedLength();

                entity.Property(e => e.ApproveBy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("APPROVE_BY")
                    .IsFixedLength();

                entity.Property(e => e.ApproveDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APPROVE_DATE");

                entity.Property(e => e.ApproveId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("APPROVE_ID");

                entity.Property(e => e.Building)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BUILDING");

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_CODE")
                    .IsFixedLength();

                entity.Property(e => e.PrepareBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PREPARE_BY");

                entity.Property(e => e.PrepareDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PREPARE_DATE");

                entity.Property(e => e.StsLoad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STS_LOAD")
                    .IsFixedLength();

                entity.Property(e => e.SupempNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SUPEMP_NO")
                    .IsFixedLength();

                entity.Property(e => e.SupsiteId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPSITE_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<EsdEmpTmplist>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.EmpNo })
                    .HasName("PK_EMPTMPLIST");

                entity.ToTable("ESD_EMP_TMPLIST");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SITE_ID")
                    .IsFixedLength();

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EMP_NO");

                entity.Property(e => e.ApproveBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("APPROVE_BY");

                entity.Property(e => e.ApproveDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APPROVE_DATE");

                entity.Property(e => e.ApproveId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("APPROVE_ID");

                entity.Property(e => e.Building)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BUILDING");

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_CODE")
                    .IsFixedLength();

                entity.Property(e => e.PrepareBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PREPARE_BY");

                entity.Property(e => e.PrepareDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PREPARE_DATE");

                entity.Property(e => e.StsLoad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STS_LOAD")
                    .IsFixedLength();

                entity.Property(e => e.StsProcess)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("STS_PROCESS")
                    .IsFixedLength();

                entity.Property(e => e.SupempNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SUPEMP_NO")
                    .IsFixedLength();

                entity.Property(e => e.SupsiteId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPSITE_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<EsdEmpTmplistNew>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.EmpNo })
                    .HasName("SYS_C0015602");

                entity.ToTable("ESD_EMP_TMPLIST_NEW");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SITE_ID")
                    .IsFixedLength();

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EMP_NO");

                entity.Property(e => e.ApproveBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("APPROVE_BY");

                entity.Property(e => e.ApproveDate)
                    .HasColumnType("DATE")
                    .HasColumnName("APPROVE_DATE");

                entity.Property(e => e.ApproveId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("APPROVE_ID");

                entity.Property(e => e.Building)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BUILDING");

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_CODE")
                    .IsFixedLength();

                entity.Property(e => e.PrepareBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PREPARE_BY");

                entity.Property(e => e.PrepareDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PREPARE_DATE");

                entity.Property(e => e.StsLoad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STS_LOAD")
                    .IsFixedLength();

                entity.Property(e => e.StsProcess)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("STS_PROCESS")
                    .IsFixedLength();

                entity.Property(e => e.SupempNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SUPEMP_NO")
                    .IsFixedLength();

                entity.Property(e => e.SupsiteId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SUPSITE_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<EsdGofSt>(entity =>
            {
                entity.HasKey(e => e.GofId)
                    .HasName("ESD_GOF_STS_PK");

                entity.ToTable("ESD_GOF_STS");

                entity.Property(e => e.GofId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("GOF_ID");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_NAME");

                entity.Property(e => e.GofDate)
                    .HasColumnType("DATE")
                    .HasColumnName("GOF_DATE");

                entity.Property(e => e.GofImpDate)
                    .HasColumnType("DATE")
                    .HasColumnName("GOF_IMP_DATE");

                entity.Property(e => e.GofMsgLog)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("GOF_MSG_LOG");

                entity.Property(e => e.GofName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("GOF_NAME");

                entity.Property(e => e.GofPath)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("GOF_PATH");

                entity.Property(e => e.GofSts)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GOF_STS");
            });

            modelBuilder.Entity<EsdLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESD_LOGS");

                entity.HasIndex(e => new { e.SiteId, e.EmpNo }, "ESD_IDX01");

                entity.HasIndex(e => e.EntryDate, "ESD_IDX02");

                entity.HasIndex(e => new { e.EmpNo, e.EntryDate }, "ESD_IDX06");

                entity.HasIndex(e => new { e.SiteId, e.EmpNo, e.EntryDate }, "ESD_IDX07");

                entity.HasIndex(e => new { e.ExitDate, e.EmpNo }, "IX_ESD_LOGS_DATA_NO");

                entity.HasIndex(e => e.LogDate, "IX_ESD_LOGS_LOGDATE");

                entity.Property(e => e.Building)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BUILDING");

                entity.Property(e => e.CardCscan)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARD_CSCAN");

                entity.Property(e => e.CardMscan)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARD_MSCAN");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EMP_NO");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ENTRY_DATE");

                entity.Property(e => e.EsdShoe)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ESD_SHOE")
                    .IsFixedLength();

                entity.Property(e => e.EsdWrist)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ESD_WRIST")
                    .IsFixedLength();

                entity.Property(e => e.ExitDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EXIT_DATE");

                entity.Property(e => e.GateType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GATE_TYPE");

                entity.Property(e => e.LogDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LOG_DATE");

                entity.Property(e => e.RandomCheck)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RANDOM_CHECK");

                entity.Property(e => e.ReaderType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("READER_TYPE");

                entity.Property(e => e.ShoeLeftRst)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SHOE_LEFT_RST");

                entity.Property(e => e.ShoeLeftSts)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SHOE_LEFT_STS")
                    .IsFixedLength();

                entity.Property(e => e.ShoeRightRst)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SHOE_RIGHT_RST");

                entity.Property(e => e.ShoeRightSts)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SHOE_RIGHT_STS")
                    .IsFixedLength();

                entity.Property(e => e.SiteId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SITE_ID")
                    .IsFixedLength();

                entity.Property(e => e.SourceName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_NAME");

                entity.Property(e => e.WristRst)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WRIST_RST");
            });

            modelBuilder.Entity<EsdLogFile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESD_LOG_FILE");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.FileCreateDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILE_CREATE_DATE");

                entity.Property(e => e.Filename)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FILENAME");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.Items)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMS");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<EsdLogsArc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESD_LOGS_ARC");

                entity.Property(e => e.Building)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BUILDING");

                entity.Property(e => e.CardCscan)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARD_CSCAN");

                entity.Property(e => e.CardMscan)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARD_MSCAN");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EMP_NO");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ENTRY_DATE");

                entity.Property(e => e.EsdShoe)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ESD_SHOE")
                    .IsFixedLength();

                entity.Property(e => e.EsdWrist)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ESD_WRIST")
                    .IsFixedLength();

                entity.Property(e => e.ExitDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EXIT_DATE");

                entity.Property(e => e.GateType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GATE_TYPE");

                entity.Property(e => e.LogDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LOG_DATE");

                entity.Property(e => e.RandomCheck)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RANDOM_CHECK");

                entity.Property(e => e.ReaderType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("READER_TYPE");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SITE_ID")
                    .IsFixedLength();

                entity.Property(e => e.SourceName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_NAME");
            });

            modelBuilder.Entity<EsdLogsArcR1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESD_LOGS_ARC_R1");

                entity.Property(e => e.Building)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BUILDING");

                entity.Property(e => e.CardCscan)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARD_CSCAN");

                entity.Property(e => e.CardMscan)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARD_MSCAN");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EMP_NO");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ENTRY_DATE");

                entity.Property(e => e.EsdShoe)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ESD_SHOE")
                    .IsFixedLength();

                entity.Property(e => e.EsdWrist)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ESD_WRIST")
                    .IsFixedLength();

                entity.Property(e => e.ExitDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EXIT_DATE");

                entity.Property(e => e.GateType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GATE_TYPE");

                entity.Property(e => e.LogDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LOG_DATE");

                entity.Property(e => e.RandomCheck)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RANDOM_CHECK");

                entity.Property(e => e.ReaderType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("READER_TYPE");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SITE_ID")
                    .IsFixedLength();

                entity.Property(e => e.SourceName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_NAME");
            });

            modelBuilder.Entity<EsdLogsCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESD_LOGS_CHECK");

                entity.Property(e => e.EndFootwaer)
                    .HasColumnType("FLOAT")
                    .HasColumnName("END_FOOTWAER");

                entity.Property(e => e.FristFootwaer)
                    .HasColumnType("FLOAT")
                    .HasColumnName("FRIST_FOOTWAER");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.WristStrap)
                    .HasColumnType("NUMBER")
                    .HasColumnName("WRIST_STRAP");
            });

            modelBuilder.Entity<EsdLogsNew1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ESD_LOGS_NEW1");

                entity.HasIndex(e => new { e.EmpNo, e.EntryDate, e.SourceName }, "ESD_LOGS_NEW1_INDEX1");

                entity.Property(e => e.Building)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BUILDING");

                entity.Property(e => e.CardCscan)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARD_CSCAN");

                entity.Property(e => e.CardMscan)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARD_MSCAN");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EMP_NO");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ENTRY_DATE");

                entity.Property(e => e.EsdShoe)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ESD_SHOE")
                    .IsFixedLength();

                entity.Property(e => e.EsdWrist)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ESD_WRIST")
                    .IsFixedLength();

                entity.Property(e => e.ExitDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EXIT_DATE");

                entity.Property(e => e.Filename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILENAME");

                entity.Property(e => e.GateType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GATE_TYPE");

                entity.Property(e => e.LogDate)
                    .HasColumnType("DATE")
                    .HasColumnName("LOG_DATE");

                entity.Property(e => e.RandomCheck)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RANDOM_CHECK");

                entity.Property(e => e.ReaderType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("READER_TYPE");

                entity.Property(e => e.ShoeLeftRst)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SHOE_LEFT_RST");

                entity.Property(e => e.ShoeLeftSts)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SHOE_LEFT_STS")
                    .IsFixedLength();

                entity.Property(e => e.ShoeRightRst)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SHOE_RIGHT_RST");

                entity.Property(e => e.ShoeRightSts)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SHOE_RIGHT_STS")
                    .IsFixedLength();

                entity.Property(e => e.SiteId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SITE_ID")
                    .IsFixedLength();

                entity.Property(e => e.SourceName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_NAME");

                entity.Property(e => e.WristRst)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("WRIST_RST");
            });

            modelBuilder.Entity<EsdRemark>(entity =>
            {
                entity.ToTable("ESD_REMARK");

                entity.Property(e => e.EsdRemarkId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ESD_REMARK_ID");

                entity.Property(e => e.EsdRemarkDesc)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("ESD_REMARK_DESC");

                entity.Property(e => e.EsdRemarkSts)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ESD_REMARK_STS")
                    .HasDefaultValueSql("'ACT'");
            });

            modelBuilder.Entity<EsdSiteInfo>(entity =>
            {
                entity.HasKey(e => e.SiteId)
                    .HasName("ESD_SITE_INFO_PK11075866698500");

                entity.ToTable("ESD_SITE_INFO");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SITE_ID")
                    .IsFixedLength();

                entity.Property(e => e.SiteName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SITE_NAME");
            });

            modelBuilder.Entity<EsdSourceInfo>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.Building, e.SourceName })
                    .HasName("ESD_SOURCE_IN_PK31075866913656");

                entity.ToTable("ESD_SOURCE_INFO");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SITE_ID")
                    .IsFixedLength();

                entity.Property(e => e.Building)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BUILDING");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SOURCE_NAME");
            });

            modelBuilder.Entity<LibraryCisco>(entity =>
            {
                entity.ToTable("LIBRARY_CISCO");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Author)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("AUTHOR");

                entity.Property(e => e.FileName1)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME1");

                entity.Property(e => e.FileName10)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME10");

                entity.Property(e => e.FileName2)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME2");

                entity.Property(e => e.FileName3)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME3");

                entity.Property(e => e.FileName4)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME4");

                entity.Property(e => e.FileName5)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME5");

                entity.Property(e => e.FileName6)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME6");

                entity.Property(e => e.FileName7)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME7");

                entity.Property(e => e.FileName8)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME8");

                entity.Property(e => e.FileName9)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME9");

                entity.Property(e => e.Model)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("MODEL");

                entity.Property(e => e.ModelRev)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_REV");

                entity.Property(e => e.Pn)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("PN");

                entity.Property(e => e.Product)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT");

                entity.Property(e => e.Rev)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REV");

                entity.Property(e => e.Type)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.UpDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UP_DATE");
            });

            modelBuilder.Entity<LibraryHp>(entity =>
            {
                entity.ToTable("LIBRARY_HP");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Author)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("AUTHOR");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.FileName1)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME1");

                entity.Property(e => e.FileName10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME10");

                entity.Property(e => e.FileName2)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME2");

                entity.Property(e => e.FileName3)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME3");

                entity.Property(e => e.FileName4)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME4");

                entity.Property(e => e.FileName5)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME5");

                entity.Property(e => e.FileName6)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME6");

                entity.Property(e => e.FileName7)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME7");

                entity.Property(e => e.FileName8)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME8");

                entity.Property(e => e.FileName9)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME9");

                entity.Property(e => e.PnRev)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("PN_REV");

                entity.Property(e => e.Product)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT");

                entity.Property(e => e.Type)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.UpDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UP_DATE");
            });

            modelBuilder.Entity<LibraryMatrox>(entity =>
            {
                entity.ToTable("LIBRARY_MATROX");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Author)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("AUTHOR");

                entity.Property(e => e.FileName1)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME1");

                entity.Property(e => e.FileName10)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME10");

                entity.Property(e => e.FileName2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME2");

                entity.Property(e => e.FileName3)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME3");

                entity.Property(e => e.FileName4)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME4");

                entity.Property(e => e.FileName5)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME5");

                entity.Property(e => e.FileName6)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME6");

                entity.Property(e => e.FileName7)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME7");

                entity.Property(e => e.FileName8)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME8");

                entity.Property(e => e.FileName9)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME9");

                entity.Property(e => e.Pn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PN");

                entity.Property(e => e.Rev)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REV");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.UpDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UP_DATE");
            });

            modelBuilder.Entity<LibraryMaxtor>(entity =>
            {
                entity.ToTable("LIBRARY_MAXTOR");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Author)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("AUTHOR");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.FileName1)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME1");

                entity.Property(e => e.FileName10)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME10");

                entity.Property(e => e.FileName2)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME2");

                entity.Property(e => e.FileName3)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME3");

                entity.Property(e => e.FileName4)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME4");

                entity.Property(e => e.FileName5)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME5");

                entity.Property(e => e.FileName6)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME6");

                entity.Property(e => e.FileName7)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME7");

                entity.Property(e => e.FileName8)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME8");

                entity.Property(e => e.FileName9)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME9");

                entity.Property(e => e.PnRev)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("PN_REV");

                entity.Property(e => e.Product)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT");

                entity.Property(e => e.Type)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.UpDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UP_DATE");
            });

            modelBuilder.Entity<LibraryNeec>(entity =>
            {
                entity.ToTable("LIBRARY_NEEC");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Author)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("AUTHOR");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.FileName1)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME1");

                entity.Property(e => e.FileName10)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME10");

                entity.Property(e => e.FileName2)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME2");

                entity.Property(e => e.FileName3)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME3");

                entity.Property(e => e.FileName4)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME4");

                entity.Property(e => e.FileName5)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME5");

                entity.Property(e => e.FileName6)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME6");

                entity.Property(e => e.FileName7)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME7");

                entity.Property(e => e.FileName8)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME8");

                entity.Property(e => e.FileName9)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME9");

                entity.Property(e => e.Pn)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("PN");

                entity.Property(e => e.Product)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT");

                entity.Property(e => e.Rev)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REV");

                entity.Property(e => e.Type)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.UpDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UP_DATE");
            });

            modelBuilder.Entity<LibraryNokium>(entity =>
            {
                entity.ToTable("LIBRARY_NOKIA");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Author)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("AUTHOR");

                entity.Property(e => e.Data)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DATA");

                entity.Property(e => e.FileName1)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME1");

                entity.Property(e => e.FileName10)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME10");

                entity.Property(e => e.FileName2)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME2");

                entity.Property(e => e.FileName3)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME3");

                entity.Property(e => e.FileName4)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME4");

                entity.Property(e => e.FileName5)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME5");

                entity.Property(e => e.FileName6)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME6");

                entity.Property(e => e.FileName7)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME7");

                entity.Property(e => e.FileName8)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME8");

                entity.Property(e => e.FileName9)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME9");

                entity.Property(e => e.NDate)
                    .HasColumnType("DATE")
                    .HasColumnName("N_DATE");

                entity.Property(e => e.Pn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PN");

                entity.Property(e => e.Product)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT");

                entity.Property(e => e.Rev)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REV");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<LibraryNvidium>(entity =>
            {
                entity.ToTable("LIBRARY_NVIDIA");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Author)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("AUTHOR");

                entity.Property(e => e.FileName1)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME1");

                entity.Property(e => e.FileName10)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME10");

                entity.Property(e => e.FileName2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME2");

                entity.Property(e => e.FileName3)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME3");

                entity.Property(e => e.FileName4)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME4");

                entity.Property(e => e.FileName5)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME5");

                entity.Property(e => e.FileName6)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME6");

                entity.Property(e => e.FileName7)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME7");

                entity.Property(e => e.FileName8)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME8");

                entity.Property(e => e.FileName9)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME9");

                entity.Property(e => e.Pn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PN");

                entity.Property(e => e.Pn2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PN2");

                entity.Property(e => e.Rev)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REV");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.UpDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UP_DATE");
            });

            modelBuilder.Entity<LibraryPolycom>(entity =>
            {
                entity.ToTable("LIBRARY_POLYCOM");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Author)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("AUTHOR");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.FileName1)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME1");

                entity.Property(e => e.FileName10)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME10");

                entity.Property(e => e.FileName2)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME2");

                entity.Property(e => e.FileName3)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME3");

                entity.Property(e => e.FileName4)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME4");

                entity.Property(e => e.FileName5)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME5");

                entity.Property(e => e.FileName6)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME6");

                entity.Property(e => e.FileName7)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME7");

                entity.Property(e => e.FileName8)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME8");

                entity.Property(e => e.FileName9)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME9");

                entity.Property(e => e.Pn)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("PN");

                entity.Property(e => e.Product)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT");

                entity.Property(e => e.Rev)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REV");

                entity.Property(e => e.Type)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");

                entity.Property(e => e.UpDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UP_DATE");
            });

            modelBuilder.Entity<Manpowerst>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MANPOWERST");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Line)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LINE");

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PART_NUMBER");

                entity.Property(e => e.St)
                    .HasColumnType("FLOAT")
                    .HasColumnName("ST");
            });

            modelBuilder.Entity<Micro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MICRO");

                entity.Property(e => e.Datestaff)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DATESTAFF");

                entity.Property(e => e.Depapp1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPAPP1");

                entity.Property(e => e.Depapp2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPAPP2");

                entity.Property(e => e.Depapp3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPAPP3");

                entity.Property(e => e.Depapp4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPAPP4");

                entity.Property(e => e.Depapp5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPAPP5");

                entity.Property(e => e.Department)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Des1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DES1");

                entity.Property(e => e.Des2)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DES2");

                entity.Property(e => e.Des3)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DES3");

                entity.Property(e => e.Des4)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DES4");

                entity.Property(e => e.Des5)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DES5");

                entity.Property(e => e.Dmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DMAIL");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Mail)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("MAIL");

                entity.Property(e => e.Model1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("MODEL1");

                entity.Property(e => e.Model2)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("MODEL2");

                entity.Property(e => e.Model3)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("MODEL3");

                entity.Property(e => e.Model4)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("MODEL4");

                entity.Property(e => e.Model5)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("MODEL5");

                entity.Property(e => e.Oapp1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OAPP1");

                entity.Property(e => e.Oapp2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OAPP2");

                entity.Property(e => e.Oapp3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OAPP3");

                entity.Property(e => e.Oapp4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OAPP4");

                entity.Property(e => e.Oapp5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OAPP5");

                entity.Property(e => e.Omail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OMAIL");

                entity.Property(e => e.Project)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PROJECT");

                entity.Property(e => e.Q1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Q2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Q3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Q4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Q5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Receive1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVE1");

                entity.Property(e => e.Receive2)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVE2");

                entity.Property(e => e.Receive3)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVE3");

                entity.Property(e => e.Receive4)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVE4");

                entity.Property(e => e.Receive5)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVE5");

                entity.Property(e => e.Remark1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("REMARK1");

                entity.Property(e => e.Remark2)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("REMARK2");

                entity.Property(e => e.Remark3)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("REMARK3");

                entity.Property(e => e.Remark4)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("REMARK4");

                entity.Property(e => e.Remark5)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("REMARK5");

                entity.Property(e => e.Request)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("REQUEST");

                entity.Property(e => e.Section)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SECTION");

                entity.Property(e => e.Serial1)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL1");

                entity.Property(e => e.Serial2)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL2");

                entity.Property(e => e.Serial3)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL3");

                entity.Property(e => e.Serial4)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL4");

                entity.Property(e => e.Serial5)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("SERIAL5");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Supapp)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SUPAPP");

                entity.Property(e => e.Supapp1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SUPAPP1");

                entity.Property(e => e.Supapp2)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SUPAPP2");

                entity.Property(e => e.Supapp3)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SUPAPP3");

                entity.Property(e => e.Supapp4)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SUPAPP4");

                entity.Property(e => e.Supapp5)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SUPAPP5");
            });

            modelBuilder.Entity<Productionhl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PRODUCTIONHL");

                entity.Property(e => e.Ddate)
                    .HasColumnType("DATE")
                    .HasColumnName("DDATE");

                entity.Property(e => e.Filename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILENAME")
                    .IsFixedLength();

                entity.Property(e => e.No)
                    .HasPrecision(10)
                    .HasColumnName("NO");

                entity.Property(e => e.Owner)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OWNER")
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TYPE")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SmtCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerCode)
                    .HasName("SYS_C0015741");

                entity.ToTable("SMT_CUSTOMER");

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_CODE");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NAME");
            });

            modelBuilder.Entity<SmtProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("SYS_C0015058");

                entity.ToTable("SMT_PRODUCT");

                entity.Property(e => e.ProductId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PRODUCT_ID");

                entity.Property(e => e.Customer)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT_NAME");

                entity.Property(e => e.ProductPn)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT_PN");

                entity.Property(e => e.Profile1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PROFILE1");

                entity.Property(e => e.Profile2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PROFILE2");

                entity.Property(e => e.Revision)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REVISION");

                entity.Property(e => e.Stencil1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STENCIL1");

                entity.Property(e => e.Stencil2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STENCIL2");

                entity.Property(e => e.Stencil3)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STENCIL3");

                entity.Property(e => e.Stencil4)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STENCIL4");
            });

            modelBuilder.Entity<SmtProfile>(entity =>
            {
                entity.HasKey(e => e.ProfileId)
                    .HasName("SYS_C0015036");

                entity.ToTable("SMT_PROFILES");

                entity.Property(e => e.ProfileId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PROFILE_ID");

                entity.Property(e => e.Assigned)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGNED");

                entity.Property(e => e.Bottom)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BOTTOM");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Panel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PANEL");

                entity.Property(e => e.ProfileSn)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PROFILE_SN");

                entity.Property(e => e.Recipe)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RECIPE");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Slot)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SLOT");

                entity.Property(e => e.Tc1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TC1");

                entity.Property(e => e.Tc2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TC2");

                entity.Property(e => e.Tc3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TC3");

                entity.Property(e => e.Tc4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TC4");

                entity.Property(e => e.Tc5)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TC5");

                entity.Property(e => e.Tc6)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TC6");

                entity.Property(e => e.Tc7)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TC7");

                entity.Property(e => e.Tc8)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TC8");

                entity.Property(e => e.Tc9)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TC9");

                entity.Property(e => e.Top)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TOP");
            });

            modelBuilder.Entity<SmtStencil>(entity =>
            {
                entity.HasKey(e => e.StencilId)
                    .HasName("SYS_C0015484");

                entity.ToTable("SMT_STENCILS");

                entity.Property(e => e.StencilId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("STENCIL_ID");

                entity.Property(e => e.A)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Assigned)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGNED");

                entity.Property(e => e.B)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImageType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_TYPE");

                entity.Property(e => e.Iri)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IRI");

                entity.Property(e => e.PrintProgram)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRINT_PROGRAM");

                entity.Property(e => e.ReceiveDate)
                    .HasColumnType("DATE")
                    .HasColumnName("RECEIVE_DATE");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Side)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SIDE");

                entity.Property(e => e.Slot)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SLOT");

                entity.Property(e => e.StencilModify)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("STENCIL_MODIFY");

                entity.Property(e => e.StencilSn)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STENCIL_SN");
            });

            modelBuilder.Entity<TjArea>(entity =>
            {
                entity.HasKey(e => e.AreaId)
                    .HasName("TJ_AREA_PK");

                entity.ToTable("TJ_AREA");

                entity.Property(e => e.AreaId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AREA_ID");

                entity.Property(e => e.AreaDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AREA_DESC");

                entity.Property(e => e.AreaStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AREA_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<TjCatDetail>(entity =>
            {
                entity.HasKey(e => e.CatDetailId)
                    .HasName("TJ_CAT_DETAIL_PK");

                entity.ToTable("TJ_CAT_DETAIL");

                entity.Property(e => e.CatDetailId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CAT_DETAIL_ID");

                entity.Property(e => e.CatId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CAT_ID");

                entity.Property(e => e.ProblemCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROBLEM_CODE");

                entity.Property(e => e.ProblemDetail)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("PROBLEM_DETAIL");

                entity.Property(e => e.ProblemStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PROBLEM_STATUS");

                entity.Property(e => e.ReqPriorityId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("REQ_PRIORITY_ID");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<TjCategory>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("TJ_CATEGORIES");

                entity.ToTable("TJ_CATEGORIES");

                entity.Property(e => e.CatId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CAT_ID");

                entity.Property(e => e.CatName)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("CAT_NAME");

                entity.Property(e => e.CatStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CAT_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<TjEqm>(entity =>
            {
                entity.HasKey(e => e.EqmId)
                    .HasName("TJ_EQM_PK");

                entity.ToTable("TJ_EQM");

                entity.Property(e => e.EqmId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("EQM_ID");

                entity.Property(e => e.EqmName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EQM_NAME");

                entity.Property(e => e.EqmStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("EQM_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<TjEqmType>(entity =>
            {
                entity.HasKey(e => e.EqmTypeId)
                    .HasName("TJ_EQM_TYPE_ID");

                entity.ToTable("TJ_EQM_TYPE");

                entity.Property(e => e.EqmTypeId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("EQM_TYPE_ID");

                entity.Property(e => e.EqmId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("EQM_ID");

                entity.Property(e => e.EqmPmForm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EQM_PM_FORM");

                entity.Property(e => e.EqmTypeName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EQM_TYPE_NAME");

                entity.Property(e => e.EqmTypeStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("EQM_TYPE_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<TjFileUpload>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("TJ_FILE_UPLOAD_PK");

                entity.ToTable("TJ_FILE_UPLOAD");

                entity.Property(e => e.FileId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("FILE_ID");

                entity.Property(e => e.FileContentType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FILE_CONTENT_TYPE");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FILE_NAME");

                entity.Property(e => e.FileSize)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FILE_SIZE");
            });

            modelBuilder.Entity<TjImg>(entity =>
            {
                entity.HasKey(e => e.ImgId)
                    .HasName("TJ_IMG_PK");

                entity.ToTable("TJ_IMG");

                entity.Property(e => e.ImgId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IMG_ID");

                entity.Property(e => e.ImgDefault)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IMG_DEFAULT");

                entity.Property(e => e.ImgDesc)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("IMG_DESC");

                entity.Property(e => e.ImgName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("IMG_NAME");

                entity.Property(e => e.ImgStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IMG_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<TjInvReq>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .HasName("TJ_INV_REQ_PK");

                entity.ToTable("TJ_INV_REQ");

                entity.Property(e => e.RequestId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("REQUEST_ID");

                entity.Property(e => e.AssignBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGN_BY");

                entity.Property(e => e.AssignByEmpNo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGN_BY_EMP_NO");

                entity.Property(e => e.AssignDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ASSIGN_DATE");

                entity.Property(e => e.CatDetailId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CAT_DETAIL_ID");

                entity.Property(e => e.CatId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CAT_ID");

                entity.Property(e => e.CompleteDate)
                    .HasColumnType("DATE")
                    .HasColumnName("COMPLETE_DATE");

                entity.Property(e => e.EmpReq)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("EMP_REQ");

                entity.Property(e => e.LineId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.MsgToUser)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("MSG_TO_USER");

                entity.Property(e => e.ProbleSolveDesc)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("PROBLE_SOLVE_DESC");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROD_ID");

                entity.Property(e => e.ReqPriorityId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("REQ_PRIORITY_ID");

                entity.Property(e => e.RequestDate)
                    .HasColumnType("DATE")
                    .HasColumnName("REQUEST_DATE");

                entity.Property(e => e.RequestDetail)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("REQUEST_DETAIL");

                entity.Property(e => e.StationId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STATION_ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<TjInvSupport>(entity =>
            {
                entity.HasKey(e => new { e.SupportId, e.RequestId, e.AssignTo })
                    .HasName("TJ_INV_SUPPORT_PK");

                entity.ToTable("TJ_INV_SUPPORT");

                entity.Property(e => e.SupportId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SUPPORT_ID");

                entity.Property(e => e.RequestId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("REQUEST_ID");

                entity.Property(e => e.AssignTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGN_TO");

                entity.Property(e => e.AssignToEmpNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ASSIGN_TO_EMP_NO");

                entity.Property(e => e.CallBackMsg)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("CALL_BACK_MSG");

                entity.Property(e => e.Remark)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.RootJob)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ROOT_JOB");

                entity.Property(e => e.SupportStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SUPPORT_STATUS");

                entity.Property(e => e.WorkEnd)
                    .HasColumnType("DATE")
                    .HasColumnName("WORK_END");

                entity.Property(e => e.WorkStart)
                    .HasColumnType("DATE")
                    .HasColumnName("WORK_START");
            });

            modelBuilder.Entity<TjLine>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("TJ_LINE_PK");

                entity.ToTable("TJ_LINE");

                entity.Property(e => e.LineId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.LineName)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("LINE_NAME");

                entity.Property(e => e.LineStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("LINE_STATUS");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROD_ID");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<TjMap>(entity =>
            {
                entity.HasKey(e => e.MapId)
                    .HasName("TJ_MAP_PK");

                entity.ToTable("TJ_MAP");

                entity.Property(e => e.MapId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MAP_ID");

                entity.Property(e => e.Border)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BORDER")
                    .HasDefaultValueSql("'Y'")
                    .IsFixedLength();

                entity.Property(e => e.Height)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HEIGHT");

                entity.Property(e => e.ImgId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IMG_ID");

                entity.Property(e => e.LineId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROD_ID");

                entity.Property(e => e.StationId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STATION_ID");

                entity.Property(e => e.Text)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("TEXT");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.Url)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("URL");

                entity.Property(e => e.Width)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WIDTH");

                entity.Property(e => e.X1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.X2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Y1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Y2)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TjMdEff>(entity =>
            {
                entity.HasKey(e => e.MdEffId)
                    .HasName("TJ_MD_EFF_PK");

                entity.ToTable("TJ_MD_EFF");

                entity.Property(e => e.MdEffId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MD_EFF_ID");

                entity.Property(e => e.MdEff)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MD_EFF");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<TjMdEffItem>(entity =>
            {
                entity.HasKey(e => e.MdEffItemId)
                    .HasName("TJ_MD_EFF_ITEM_PK");

                entity.ToTable("TJ_MD_EFF_ITEM");

                entity.Property(e => e.MdEffItemId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MD_EFF_ITEM_ID");

                entity.Property(e => e.MdEffId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MD_EFF_ID");

                entity.Property(e => e.NumEqm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NUM_EQM");

                entity.Property(e => e.NumEqmDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NUM_EQM_DESC");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<TjMsgToUser>(entity =>
            {
                entity.HasKey(e => e.TjMsgId)
                    .HasName("TJ_MSG_TO_USER_PK1");

                entity.ToTable("TJ_MSG_TO_USER");

                entity.Property(e => e.TjMsgId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("TJ_MSG_ID");

                entity.Property(e => e.MsgBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSG_BY");

                entity.Property(e => e.MsgDate)
                    .HasColumnType("DATE")
                    .HasColumnName("MSG_DATE");

                entity.Property(e => e.MsgToUser)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("MSG_TO_USER");

                entity.Property(e => e.RequestId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("REQUEST_ID");

                entity.Property(e => e.SupportId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SUPPORT_ID");
            });

            modelBuilder.Entity<TjPmF1>(entity =>
            {
                entity.HasKey(e => e.PmF1Id)
                    .HasName("TJ_PM_F1_PK");

                entity.ToTable("TJ_PM_F1");

                entity.Property(e => e.PmF1Id)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PM_F1_ID");

                entity.Property(e => e.ActTorque1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACT_TORQUE_1");

                entity.Property(e => e.ActTorque2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACT_TORQUE_2");

                entity.Property(e => e.ActTorque3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACT_TORQUE_3");

                entity.Property(e => e.ActTorqueAvg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACT_TORQUE_AVG");

                entity.Property(e => e.BfCalibrate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BF_CALIBRATE");

                entity.Property(e => e.BitCheck)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BIT_CHECK");

                entity.Property(e => e.BitType)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("BIT_TYPE");

                entity.Property(e => e.Ceaning)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CEANING");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Result)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RESULT");

                entity.Property(e => e.ScrewNo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SCREW_NO");

                entity.Property(e => e.Sn)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.Torque1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TORQUE_1");

                entity.Property(e => e.Torque2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TORQUE_2");
            });

            modelBuilder.Entity<TjPmF2Hearder>(entity =>
            {
                entity.HasKey(e => e.PmId)
                    .HasName("TJ_PM_F2_HEARDER_PK");

                entity.ToTable("TJ_PM_F2_HEARDER");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.Action)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ACTION");

                entity.Property(e => e.AirLonizerType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AIR_LONIZER_TYPE");

                entity.Property(e => e.Chk1LightSts)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CHK1_LIGHT_STS");

                entity.Property(e => e.Chk2LightSts)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CHK2_LIGHT_STS");

                entity.Property(e => e.Conclusion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CONCLUSION");

                entity.Property(e => e.ConclusionDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("CONCLUSION_DESC");

                entity.Property(e => e.Distance1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DISTANCE1");

                entity.Property(e => e.Distance2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DISTANCE2");

                entity.Property(e => e.Distance3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DISTANCE3");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Sn)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SN");
            });

            modelBuilder.Entity<TjPmF2Item>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TJ_PM_F2_ITEM");

                entity.Property(e => e.Fan1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAN1");

                entity.Property(e => e.Fan2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAN2");

                entity.Property(e => e.Fan3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAN3");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ITEM_TYPE");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.Result)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RESULT");

                entity.Property(e => e.Section)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SECTION");

                entity.Property(e => e.VoltType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VOLT_TYPE");
            });

            modelBuilder.Entity<TjPmF3>(entity =>
            {
                entity.HasKey(e => e.PmF3Id)
                    .HasName("TJ_PM_F3_PK");

                entity.ToTable("TJ_PM_F3");

                entity.Property(e => e.PmF3Id)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PM_F3_ID");

                entity.Property(e => e.Actual)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTUAL");

                entity.Property(e => e.Gverify)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GVERIFY");

                entity.Property(e => e.ModelEffect)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_EFFECT");

                entity.Property(e => e.NumEqm)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("NUM_EQM");

                entity.Property(e => e.PmDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PM_DESC");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Result)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RESULT");

                entity.Property(e => e.Spec)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SPEC");
            });

            modelBuilder.Entity<TjPmF4>(entity =>
            {
                entity.HasKey(e => e.PmF4Id)
                    .HasName("TJ_PM_F4_PK");

                entity.ToTable("TJ_PM_F4");

                entity.Property(e => e.PmF4Id)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PM_F4_ID");

                entity.Property(e => e.CapActual)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CAP_ACTUAL");

                entity.Property(e => e.CapResult)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CAP_RESULT");

                entity.Property(e => e.ClrMachine)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLR_MACHINE");

                entity.Property(e => e.CocPreFilter)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COC_PRE_FILTER");

                entity.Property(e => e.GnrCheck)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GNR_CHECK");

                entity.Property(e => e.Gverify)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GVERIFY");

                entity.Property(e => e.ModelEffect)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_EFFECT");

                entity.Property(e => e.NumEqm)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("NUM_EQM");

                entity.Property(e => e.PmDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PM_DESC");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");
            });

            modelBuilder.Entity<TjPmF5>(entity =>
            {
                entity.HasKey(e => e.PmF5Id)
                    .HasName("TJ_PM_F5_PK");

                entity.ToTable("TJ_PM_F5");

                entity.Property(e => e.PmF5Id)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PM_F5_ID");

                entity.Property(e => e.Cbag)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CBAG");

                entity.Property(e => e.CwcsIpa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CWCS_IPA");

                entity.Property(e => e.Cwu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CWU");

                entity.Property(e => e.Gverify)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GVERIFY");

                entity.Property(e => e.ModelEffect)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_EFFECT");

                entity.Property(e => e.NumEqm)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("NUM_EQM");

                entity.Property(e => e.PmDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PM_DESC");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Vsot)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VSOT");
            });

            modelBuilder.Entity<TjPmF6>(entity =>
            {
                entity.HasKey(e => e.PmF6Id)
                    .HasName("TJ_PM_F6_PK");

                entity.ToTable("TJ_PM_F6");

                entity.Property(e => e.PmF6Id)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PM_F6_ID");

                entity.Property(e => e.Cwv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CWV");

                entity.Property(e => e.Gv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GV");

                entity.Property(e => e.Gverify)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GVERIFY");

                entity.Property(e => e.ModelEffect)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_EFFECT");

                entity.Property(e => e.NumEqm)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("NUM_EQM");

                entity.Property(e => e.PmDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PM_DESC");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Vfbti)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VFBTI");

                entity.Property(e => e.Vfmi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VFMI");

                entity.Property(e => e.Vfpi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VFPI");
            });

            modelBuilder.Entity<TjPmF7>(entity =>
            {
                entity.HasKey(e => e.PmF7Id)
                    .HasName("TJ_PM_F7_PK");

                entity.ToTable("TJ_PM_F7");

                entity.Property(e => e.PmF7Id)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PM_F7_ID");

                entity.Property(e => e.Gverify)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GVERIFY");

                entity.Property(e => e.ModelEffect)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_EFFECT");

                entity.Property(e => e.NumEqm)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("NUM_EQM");

                entity.Property(e => e.PmDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PM_DESC");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.TestRun)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TEST_RUN");

                entity.Property(e => e.Vacmb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VACMB");

                entity.Property(e => e.Vact)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VACT");

                entity.Property(e => e.Vttgcm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VTTGCM");

                entity.Property(e => e.VttgcmRs)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VTTGCM_RS");

                entity.Property(e => e.Vttgpm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VTTGPM");

                entity.Property(e => e.VttgpmRs)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VTTGPM_RS");

                entity.Property(e => e.Vttgrm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VTTGRM");

                entity.Property(e => e.VttgrmRs)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VTTGRM_RS");
            });

            modelBuilder.Entity<TjPmF8>(entity =>
            {
                entity.HasKey(e => e.PmF8Id)
                    .HasName("TJ_PM_F8_PK");

                entity.ToTable("TJ_PM_F8");

                entity.Property(e => e.PmF8Id)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PM_F8_ID");

                entity.Property(e => e.Cleaning)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLEANING");

                entity.Property(e => e.CvqtahsActual)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CVQTAHS_ACTUAL");

                entity.Property(e => e.CvqtahsSpec)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CVQTAHS_SPEC");

                entity.Property(e => e.Gverify)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GVERIFY");

                entity.Property(e => e.LocGr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LOC_GR");

                entity.Property(e => e.LocLy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LOC_LY");

                entity.Property(e => e.Lubricant)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LUBRICANT");

                entity.Property(e => e.ModelEffect)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_EFFECT");

                entity.Property(e => e.NumEqm)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("NUM_EQM");

                entity.Property(e => e.PmDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PM_DESC");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.RpmCantu)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RPM_CANTU");

                entity.Property(e => e.RpmRfu)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RPM_RFU");

                entity.Property(e => e.RpmTf)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RPM_TF");

                entity.Property(e => e.Snl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SNL");

                entity.Property(e => e.SpecA)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SPEC_A");

                entity.Property(e => e.SpecRs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SPEC_RS");

                entity.Property(e => e.SpecS)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SPEC_S");

                entity.Property(e => e.Vatfoc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VATFOC");

                entity.Property(e => e.Vcatrf)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VCATRF");

                entity.Property(e => e.Vci)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VCI");

                entity.Property(e => e.Vclat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VCLAT");

                entity.Property(e => e.VqosA)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VQOS_A");

                entity.Property(e => e.VqosS)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VQOS_S");

                entity.Property(e => e.Vsotps)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VSOTPS");

                entity.Property(e => e.Vtos)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VTOS");

                entity.Property(e => e.VttcA)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VTTC_A");

                entity.Property(e => e.VttcS)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VTTC_S");

                entity.Property(e => e.Vtw)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VTW");
            });

            modelBuilder.Entity<TjPmScheduled>(entity =>
            {
                entity.HasKey(e => e.PmId)
                    .HasName("TJ_PM_SCHEDULED_PK");

                entity.ToTable("TJ_PM_SCHEDULED");

                entity.Property(e => e.PmId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PM_ID");

                entity.Property(e => e.CompleteDate)
                    .HasColumnType("DATE")
                    .HasColumnName("COMPLETE_DATE");

                entity.Property(e => e.EqmId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("EQM_ID");

                entity.Property(e => e.EqmTypeId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("EQM_TYPE_ID");

                entity.Property(e => e.LineId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.PmDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PM_DATE");

                entity.Property(e => e.PmDesc)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("PM_DESC");

                entity.Property(e => e.PmStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PM_STATUS");

                entity.Property(e => e.PmType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PM_TYPE");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROD_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.StationId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STATION_ID");

                entity.Property(e => e.SupportBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUPPORT_BY");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<TjProdGrp>(entity =>
            {
                entity.HasKey(e => e.ProdId)
                    .HasName("TJ_PROD_GRP_PK");

                entity.ToTable("TJ_PROD_GRP");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROD_ID");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("PROD_NAME");

                entity.Property(e => e.ProdStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PROD_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<TjReqPriority>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TJ_REQ_PRIORITY");

                entity.Property(e => e.ReqPriorityCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REQ_PRIORITY_CODE");

                entity.Property(e => e.ReqPriorityDesc)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("REQ_PRIORITY_DESC");

                entity.Property(e => e.ReqPriorityId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("REQ_PRIORITY_ID");

                entity.Property(e => e.ReqPriorityStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("REQ_PRIORITY_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<TjStation>(entity =>
            {
                entity.HasKey(e => e.StationId)
                    .HasName("TJ_STATION_PK");

                entity.ToTable("TJ_STATION");

                entity.Property(e => e.StationId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STATION_ID");

                entity.Property(e => e.LineId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("LINE_ID");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROD_ID");

                entity.Property(e => e.StationName)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("STATION_NAME");

                entity.Property(e => e.StationStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("STATION_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<TjSupAreaConf>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.LoginName })
                    .HasName("TJ_SUPAREA_CONF_PK");

                entity.ToTable("TJ_SUP_AREA_CONF");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROD_ID");

                entity.Property(e => e.LoginName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOGIN_NAME");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<TjWbAnswer>(entity =>
            {
                entity.HasKey(e => e.AnsId)
                    .HasName("TJ_WB_ANSWER_PK");

                entity.ToTable("TJ_WB_ANSWER");

                entity.Property(e => e.AnsId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ANS_ID");

                entity.Property(e => e.AnsDate)
                    .HasColumnType("DATE")
                    .HasColumnName("ANS_DATE");

                entity.Property(e => e.AnsLoginName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ANS_LOGIN_NAME");

                entity.Property(e => e.Answer)
                    .IsUnicode(false)
                    .HasColumnName("ANSWER");

                entity.Property(e => e.FileId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("FILE_ID");

                entity.Property(e => e.QId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Q_ID");
            });

            modelBuilder.Entity<TjWbQcat>(entity =>
            {
                entity.HasKey(e => e.QcatId)
                    .HasName("TJ_QCAT_PK");

                entity.ToTable("TJ_WB_QCAT");

                entity.Property(e => e.QcatId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("QCAT_ID");

                entity.Property(e => e.QcatDesc)
                    .IsUnicode(false)
                    .HasColumnName("QCAT_DESC");

                entity.Property(e => e.QcatStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("QCAT_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<TjWbQuestion>(entity =>
            {
                entity.HasKey(e => e.QId)
                    .HasName("TJ_WB_QUESTION_PK");

                entity.ToTable("TJ_WB_QUESTION");

                entity.Property(e => e.QId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Q_ID");

                entity.Property(e => e.FileId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("FILE_ID");

                entity.Property(e => e.FromShiftId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FROM_SHIFT_ID");

                entity.Property(e => e.Qanswer)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QANSWER");

                entity.Property(e => e.QcatId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("QCAT_ID");

                entity.Property(e => e.Qdate)
                    .HasColumnType("DATE")
                    .HasColumnName("QDATE");

                entity.Property(e => e.Qdetail)
                    .IsUnicode(false)
                    .HasColumnName("QDETAIL");

                entity.Property(e => e.QloginName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QLOGIN_NAME");

                entity.Property(e => e.Qreader)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QREADER");

                entity.Property(e => e.Qtopic)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("QTOPIC");

                entity.Property(e => e.ToShiftId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TO_SHIFT_ID");
            });

            modelBuilder.Entity<TjWorkTime>(entity =>
            {
                entity.HasKey(e => e.TimeId)
                    .HasName("TJ_TIMESHEETS_PK");

                entity.ToTable("TJ_WORK_TIME");

                entity.Property(e => e.TimeId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIME_ID");

                entity.Property(e => e.TimeDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TIME_DESC");

                entity.Property(e => e.TimeStatus)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TIME_STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<ToadPlanTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TOAD_PLAN_TABLE");

                entity.Property(e => e.AccessPredicates)
                    .IsUnicode(false)
                    .HasColumnName("ACCESS_PREDICATES");

                entity.Property(e => e.Bytes)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BYTES");

                entity.Property(e => e.Cardinality)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CARDINALITY");

                entity.Property(e => e.Cost)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("COST");

                entity.Property(e => e.CpuCost)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CPU_COST");

                entity.Property(e => e.Depth)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEPTH");

                entity.Property(e => e.Distribution)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DISTRIBUTION");

                entity.Property(e => e.FilterPredicates)
                    .IsUnicode(false)
                    .HasColumnName("FILTER_PREDICATES");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ID");

                entity.Property(e => e.IoCost)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IO_COST");

                entity.Property(e => e.ObjectAlias)
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_ALIAS");

                entity.Property(e => e.ObjectInstance)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("OBJECT_INSTANCE");

                entity.Property(e => e.ObjectName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_NAME");

                entity.Property(e => e.ObjectNode)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_NODE");

                entity.Property(e => e.ObjectOwner)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_OWNER");

                entity.Property(e => e.ObjectType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OBJECT_TYPE");

                entity.Property(e => e.Operation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OPERATION");

                entity.Property(e => e.Optimizer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OPTIMIZER");

                entity.Property(e => e.Options)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OPTIONS");

                entity.Property(e => e.Other)
                    .HasColumnType("LONG")
                    .HasColumnName("OTHER");

                entity.Property(e => e.OtherTag)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OTHER_TAG");

                entity.Property(e => e.OtherXml)
                    .HasColumnType("CLOB")
                    .HasColumnName("OTHER_XML");

                entity.Property(e => e.ParentId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PARENT_ID");

                entity.Property(e => e.PartitionId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PARTITION_ID");

                entity.Property(e => e.PartitionStart)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PARTITION_START");

                entity.Property(e => e.PartitionStop)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PARTITION_STOP");

                entity.Property(e => e.PlanId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PLAN_ID");

                entity.Property(e => e.Position)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("POSITION");

                entity.Property(e => e.Projection)
                    .IsUnicode(false)
                    .HasColumnName("PROJECTION");

                entity.Property(e => e.QblockName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("QBLOCK_NAME");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.SearchColumns)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEARCH_COLUMNS");

                entity.Property(e => e.StatementId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STATEMENT_ID");

                entity.Property(e => e.TempSpace)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TEMP_SPACE");

                entity.Property(e => e.Time)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TIME");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("DATE")
                    .HasColumnName("TIMESTAMP");
            });

            modelBuilder.Entity<VEmplist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_EMPLIST");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
