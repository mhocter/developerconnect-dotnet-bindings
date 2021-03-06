/* 
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Model;
using Elli.Api.Loans.Client;
using System.Reflection;

namespace Elli.Api.Loans.Test
{
    /// <summary>
    ///  Class for testing LoanContractAffiliatedBusinessArrangements
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanContractAffiliatedBusinessArrangementsTests
    {
        // TODO uncomment below to declare an instance variable for LoanContractAffiliatedBusinessArrangements
        //private LoanContractAffiliatedBusinessArrangements instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanContractAffiliatedBusinessArrangements
            //instance = new LoanContractAffiliatedBusinessArrangements();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanContractAffiliatedBusinessArrangements
        /// </summary>
        [Test]
        public void LoanContractAffiliatedBusinessArrangementsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanContractAffiliatedBusinessArrangements
            //Assert.IsInstanceOfType<LoanContractAffiliatedBusinessArrangements> (instance, "variable 'instance' is a LoanContractAffiliatedBusinessArrangements");
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'LenderName'
        /// </summary>
        [Test]
        public void LenderNameTest()
        {
            // TODO unit test for the property 'LenderName'
        }
        /// <summary>
        /// Test the property 'LenderAddress'
        /// </summary>
        [Test]
        public void LenderAddressTest()
        {
            // TODO unit test for the property 'LenderAddress'
        }
        /// <summary>
        /// Test the property 'LenderAddressCity'
        /// </summary>
        [Test]
        public void LenderAddressCityTest()
        {
            // TODO unit test for the property 'LenderAddressCity'
        }
        /// <summary>
        /// Test the property 'LenderAddressState'
        /// </summary>
        [Test]
        public void LenderAddressStateTest()
        {
            // TODO unit test for the property 'LenderAddressState'
        }
        /// <summary>
        /// Test the property 'LenderAddressZipcode'
        /// </summary>
        [Test]
        public void LenderAddressZipcodeTest()
        {
            // TODO unit test for the property 'LenderAddressZipcode'
        }
        /// <summary>
        /// Test the property 'AffiliateName'
        /// </summary>
        [Test]
        public void AffiliateNameTest()
        {
            // TODO unit test for the property 'AffiliateName'
        }
        /// <summary>
        /// Test the property 'NatureOfRelationship'
        /// </summary>
        [Test]
        public void NatureOfRelationshipTest()
        {
            // TODO unit test for the property 'NatureOfRelationship'
        }
        /// <summary>
        /// Test the property 'SettlementIndicator'
        /// </summary>
        [Test]
        public void SettlementIndicatorTest()
        {
            // TODO unit test for the property 'SettlementIndicator'
        }
        /// <summary>
        /// Test the property 'PurchaseSaleRefinanceIndicator'
        /// </summary>
        [Test]
        public void PurchaseSaleRefinanceIndicatorTest()
        {
            // TODO unit test for the property 'PurchaseSaleRefinanceIndicator'
        }
        /// <summary>
        /// Test the property 'ServiceDescription1'
        /// </summary>
        [Test]
        public void ServiceDescription1Test()
        {
            // TODO unit test for the property 'ServiceDescription1'
        }
        /// <summary>
        /// Test the property 'ServiceDescription2'
        /// </summary>
        [Test]
        public void ServiceDescription2Test()
        {
            // TODO unit test for the property 'ServiceDescription2'
        }
        /// <summary>
        /// Test the property 'ServiceDescription3'
        /// </summary>
        [Test]
        public void ServiceDescription3Test()
        {
            // TODO unit test for the property 'ServiceDescription3'
        }
        /// <summary>
        /// Test the property 'ServiceDescription4'
        /// </summary>
        [Test]
        public void ServiceDescription4Test()
        {
            // TODO unit test for the property 'ServiceDescription4'
        }
        /// <summary>
        /// Test the property 'ServiceDescription5'
        /// </summary>
        [Test]
        public void ServiceDescription5Test()
        {
            // TODO unit test for the property 'ServiceDescription5'
        }
        /// <summary>
        /// Test the property 'ServiceDescription6'
        /// </summary>
        [Test]
        public void ServiceDescription6Test()
        {
            // TODO unit test for the property 'ServiceDescription6'
        }
        /// <summary>
        /// Test the property 'ChargeRangeChargesDescription1'
        /// </summary>
        [Test]
        public void ChargeRangeChargesDescription1Test()
        {
            // TODO unit test for the property 'ChargeRangeChargesDescription1'
        }
        /// <summary>
        /// Test the property 'ChargeRangeChargesDescription2'
        /// </summary>
        [Test]
        public void ChargeRangeChargesDescription2Test()
        {
            // TODO unit test for the property 'ChargeRangeChargesDescription2'
        }
        /// <summary>
        /// Test the property 'ChargeRangeChargesDescription3'
        /// </summary>
        [Test]
        public void ChargeRangeChargesDescription3Test()
        {
            // TODO unit test for the property 'ChargeRangeChargesDescription3'
        }
        /// <summary>
        /// Test the property 'ChargeRangeChargesDescription4'
        /// </summary>
        [Test]
        public void ChargeRangeChargesDescription4Test()
        {
            // TODO unit test for the property 'ChargeRangeChargesDescription4'
        }
        /// <summary>
        /// Test the property 'ChargeRangeChargesDescription5'
        /// </summary>
        [Test]
        public void ChargeRangeChargesDescription5Test()
        {
            // TODO unit test for the property 'ChargeRangeChargesDescription5'
        }
        /// <summary>
        /// Test the property 'ChargeRangeChargesDescription6'
        /// </summary>
        [Test]
        public void ChargeRangeChargesDescription6Test()
        {
            // TODO unit test for the property 'ChargeRangeChargesDescription6'
        }
        /// <summary>
        /// Test the property 'RequiredUseIndicator1'
        /// </summary>
        [Test]
        public void RequiredUseIndicator1Test()
        {
            // TODO unit test for the property 'RequiredUseIndicator1'
        }
        /// <summary>
        /// Test the property 'RequiredUseIndicator2'
        /// </summary>
        [Test]
        public void RequiredUseIndicator2Test()
        {
            // TODO unit test for the property 'RequiredUseIndicator2'
        }
        /// <summary>
        /// Test the property 'RequiredUseIndicator3'
        /// </summary>
        [Test]
        public void RequiredUseIndicator3Test()
        {
            // TODO unit test for the property 'RequiredUseIndicator3'
        }
        /// <summary>
        /// Test the property 'RequiredUseIndicator4'
        /// </summary>
        [Test]
        public void RequiredUseIndicator4Test()
        {
            // TODO unit test for the property 'RequiredUseIndicator4'
        }
        /// <summary>
        /// Test the property 'RequiredUseIndicator5'
        /// </summary>
        [Test]
        public void RequiredUseIndicator5Test()
        {
            // TODO unit test for the property 'RequiredUseIndicator5'
        }
        /// <summary>
        /// Test the property 'RequiredUseIndicator6'
        /// </summary>
        [Test]
        public void RequiredUseIndicator6Test()
        {
            // TODO unit test for the property 'RequiredUseIndicator6'
        }
        /// <summary>
        /// Test the property 'PercentOwnershipInterest'
        /// </summary>
        [Test]
        public void PercentOwnershipInterestTest()
        {
            // TODO unit test for the property 'PercentOwnershipInterest'
        }
        /// <summary>
        /// Test the property 'AffiliatedBusinessArrangementIndex'
        /// </summary>
        [Test]
        public void AffiliatedBusinessArrangementIndexTest()
        {
            // TODO unit test for the property 'AffiliatedBusinessArrangementIndex'
        }

    }

}
