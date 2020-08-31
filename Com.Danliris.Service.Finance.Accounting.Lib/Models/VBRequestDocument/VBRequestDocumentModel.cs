﻿using Com.Danliris.Service.Finance.Accounting.Lib.BusinessLogic.VBRequestDocument;
using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Com.Danliris.Service.Finance.Accounting.Lib.Models.VBRequestDocument
{
    public class VBRequestDocumentModel : StandardEntity
    {
        public VBRequestDocumentModel()
        {

        }


        // New Ctor With Index
        public VBRequestDocumentModel(string documentNo, DateTimeOffset date, DateTimeOffset realizationEstimationDate, int suppliantUnitId, string suppliantUnitCode, string suppliantUnitName,
                int suppliantDivisionId, string suppliantDivisionCode, string suppliantDivisionName, int currencyId, string currencyCode, string currencySymbol, string currencyDescription,
                double currencyRate, string purpose, decimal amount, bool isPosted, bool isApproved, bool isCompleted, VBType type, int index)
            : this(documentNo, date, realizationEstimationDate, suppliantUnitId, suppliantUnitCode, suppliantUnitName, suppliantDivisionId, suppliantDivisionCode, suppliantDivisionName,
                currencyId, currencyCode, currencySymbol, currencyDescription, currencyRate, purpose, amount, isPosted, isApproved, isCompleted, type)
        {
            Index = index;
        }

        public VBRequestDocumentModel(
            string documentNo,
            DateTimeOffset date,
            DateTimeOffset realizationEstimationDate,
            int suppliantUnitId,
            string suppliantUnitCode,
            string suppliantUnitName,
            int suppliantDivisionId,
            string suppliantDivisionCode,
            string suppliantDivisionName,
            int currencyId,
            string currencyCode,
            string currencySymbol,
            string currencyDescription,
            double currencyRate,
            string purpose,
            decimal amount,
            bool isPosted,
            bool isApproved,
            bool isCompleted,
            VBType type
            )
        {
            DocumentNo = documentNo;
            Date = date;
            RealizationEstimationDate = realizationEstimationDate;
            CurrencyId = currencyId;
            CurrencyCode = currencyCode;
            CurrencySymbol = currencySymbol;
            CurrencyRate = currencyRate;
            CurrencyDescription = currencyDescription;
            Purpose = purpose;
            Amount = amount;
            IsPosted = isPosted;
            IsApproved = isApproved;
            IsCompleted = isCompleted;
            Type = type;

            SuppliantUnitId = suppliantUnitId;
            SuppliantUnitCode = suppliantUnitCode;
            SuppliantUnitName = suppliantUnitName;
            SuppliantDivisionId = suppliantDivisionId;
            SuppliantDivisionCode = suppliantDivisionCode;
            SuppliantDivisionName = suppliantDivisionName;
        }

        [MaxLength(64)]
        public string DocumentNo { get; private set; }
        public DateTimeOffset Date { get; private set; }
        public DateTimeOffset RealizationEstimationDate { get; private set; }
        public int CurrencyId { get; private set; }
        [MaxLength(64)]
        public string CurrencyCode { get; private set; }
        [MaxLength(64)]
        public string CurrencySymbol { get; private set; }
        public double CurrencyRate { get; private set; }
        [MaxLength(256)]
        public string CurrencyDescription { get; private set; }
        public string Purpose { get; private set; }
        public decimal Amount { get; private set; }
        public bool IsPosted { get; private set; }
        public VBType Type { get; private set; }
        public int SuppliantUnitId { get; private set; }
        [MaxLength(64)]
        public string SuppliantUnitCode { get; private set; }
        [MaxLength(256)]
        public string SuppliantUnitName { get; private set; }
        public int SuppliantDivisionId { get; private set; }
        [MaxLength(64)]
        public string SuppliantDivisionCode { get; private set; }
        [MaxLength(256)]
        public string SuppliantDivisionName { get; private set; }

        public int Index { get; private set; }

        public bool IsRealized { get; private set; }


        public bool IsApproved { get; private set; }
        public DateTimeOffset? ApprovedDate { get; private set; }
        [MaxLength(256)]
        public string ApprovedBy { get; private set; }

        public bool IsCompleted { get; private set; }
        public DateTimeOffset? CompletedDate { get; private set; }
        [MaxLength(256)]
        public string CompletedBy { get; private set; }

        public void SetDate(DateTimeOffset newDate, string user, string userAgent)
        {
            if (newDate != Date)
            {
                Date = newDate;
                this.FlagForUpdate(user, userAgent);
            }
        }

        public void SetRealizationEstimationDate(DateTimeOffset newRealizationEstimationDate, string user, string userAgent)
        {
            if (newRealizationEstimationDate != RealizationEstimationDate)
            {
                RealizationEstimationDate = newRealizationEstimationDate;
                this.FlagForUpdate(user, userAgent);
            }
        }

        public void SetCurrency(int newCurrencyId, string newCurrencyCode, string newCurrencySymbol, double newCurrencyRate, string newCurrencyDescription, string user, string userAgent)
        {
            if (newCurrencyId != CurrencyId)
            {
                CurrencyId = newCurrencyId;
                this.FlagForUpdate(user, userAgent);
            }

            if (newCurrencyCode != CurrencyCode)
            {
                CurrencyCode = newCurrencyCode;
                this.FlagForUpdate(user, userAgent);
            }

            if (newCurrencySymbol != CurrencySymbol)
            {
                CurrencySymbol = newCurrencySymbol;
                this.FlagForUpdate(user, userAgent);
            }

            if (newCurrencyRate != CurrencyRate)
            {
                CurrencyRate = newCurrencyRate;
                this.FlagForUpdate(user, userAgent);
            }

            if (newCurrencyDescription != CurrencyDescription)
            {
                CurrencyDescription = newCurrencyDescription;
                this.FlagForUpdate(user, userAgent);
            }
        }

        public void SetAmount(decimal newAmount, string user, string userAgent)
        {
            if (newAmount != Amount)
            {
                Amount = newAmount;
                this.FlagForUpdate(user, userAgent);
            }
        }

        public void SetPurpose(string newPurpose, string user, string userAgent)
        {
            if (newPurpose != Purpose)
            {
                Purpose = newPurpose;
                this.FlagForUpdate(user, userAgent);
            }
        }

        public void SetIsApproved(bool newFlagIsApproved, string user, string userAgent)
        {
            if (newFlagIsApproved != IsApproved)
            {
                IsApproved = newFlagIsApproved;
                this.FlagForUpdate(user, userAgent);
            }
        }

        public void SetApprovedDate(DateTimeOffset newApprovedDate, string user, string userAgent)
        {
            if (newApprovedDate != ApprovedDate)
            {
                ApprovedDate = newApprovedDate;
                this.FlagForUpdate(user, userAgent);
            }
        }

        public void SetApprovedBy(string newApprovedBy, string user, string userAgent)
        {
            if (newApprovedBy != ApprovedBy)
            {
                ApprovedBy = newApprovedBy;
                this.FlagForUpdate(user, userAgent);
            }
        }

        public void SetIsRealized(bool newFlagIsRealized, string user, string userAgent)
        {

            if (newFlagIsRealized != IsRealized)
            {
                IsRealized = newFlagIsRealized;
                this.FlagForUpdate(user, userAgent);
            }
        }

        public void UpdateFromForm(VBRequestDocumentWithPOFormDto form)
        {
            Date = form.Date.GetValueOrDefault();
            RealizationEstimationDate = form.RealizationEstimationDate.GetValueOrDefault();
            CurrencyId = form.Currency.Id.GetValueOrDefault();
            CurrencyCode = form.Currency.Code;
            CurrencySymbol = form.Currency.Symbol;
            CurrencyRate = form.Currency.Rate.GetValueOrDefault();
            CurrencyDescription = form.Currency.Description;
            Purpose = form.Purpose;
            Amount = form.Amount.GetValueOrDefault();
            SuppliantUnitId = form.SuppliantUnit.Id.GetValueOrDefault();
            SuppliantUnitCode = form.SuppliantUnit.Code;
            SuppliantUnitName = form.SuppliantUnit.Name;
            SuppliantDivisionId = form.SuppliantUnit.Division.Id.GetValueOrDefault();
            SuppliantDivisionCode = form.SuppliantUnit.Division.Code;
            SuppliantDivisionName = form.SuppliantUnit.Division.Name;
        }
    }
}