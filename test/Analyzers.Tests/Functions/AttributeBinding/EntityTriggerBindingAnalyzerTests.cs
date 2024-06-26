﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.DurableTask.Analyzers.Functions.AttributeBinding;

namespace Microsoft.DurableTask.Analyzers.Tests.Functions.AttributeBinding;

public class EntityTriggerBindingAnalyzerTests : MatchingAttributeBindingSpecificationTests<EntityTriggerBindingAnalyzer, EntityTriggerBindingFixer>
{
    protected override string ExpectedDiagnosticId => EntityTriggerBindingAnalyzer.DiagnosticId;

    protected override string ExpectedAttribute => "[EntityTrigger]";

    protected override string ExpectedType => "TaskEntityDispatcher";
}
